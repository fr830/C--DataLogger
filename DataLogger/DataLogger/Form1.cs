using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace DataLogger
{
    public partial class Form1 : Form
    {
        public static string connectionType = "TCPIP";
        string[] connectionTypeList = { "Serial", "TCPIP", "UDP", "WEB" };
        string remoteIPAddress = "127.0.0.1";
        UInt16 remotePort = 5005;
        public Socket networkSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        DataSeriesObject dataSeries1 = new DataSeriesObject();
        Form3 ChartWindow = null;
        byte[] m_dataBuffer = new byte[10];
        string headerMask = "\r\n"; // Mask used to identify header of received packet
        string footerMask = "\r\n"; // Mask used to identify footer of received packet
        int masterDebugLevel = 1;
        bool enableDebugWindow = false;
        bool enableFileLogging = true;
        String receivedDataString = "";
        // Set a variable to the My Documents path.
        string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        StreamWriter outputFile;
        IAsyncResult m_result;
        public AsyncCallback m_pfnCallBack;
        //private System.Windows.Forms.Button btnClear;
        public delegate void UpdateRichEditCallback(string text);
        delegate void PrintDebugCallback(int debugLevel, string text);
        delegate void ProcessDataCallback(string data);
        //public Socket m_clientSocket;
        //TcpClient tcpClient;
        //NetworkStream networkStream; 
        public class DataSeriesObject
        {
            public static int SeriesLength = 3650;
            public int SeriesIndex = 0;
            public double minX = 0;
            public double maxX = 0;
            public double minY = 0;
            public double maxY = 0;
            public double[] dataSeriesX = new double[SeriesLength];
            public double[] dataSeriesY = new double[SeriesLength];
            public int getSeriesLength()
            {
                return SeriesLength;
            }
            public int addData(string[] values, int elementsToProcess)
            {
            try
            {
                    for (int i = 0; i < elementsToProcess; i++)
                    {
                        dataSeriesX[SeriesIndex] = double.Parse(values[0]);
                        dataSeriesY[SeriesIndex] = double.Parse(values[1]);
                    }
                
            }catch (Exception ex)
            {
                MessageBox.Show("UpdateChart exception:" + ex);
                    return 1;
            }
                if (SeriesIndex >= SeriesLength - 1)
                {
                    SeriesIndex = 0;
                }
                else
                {
                    SeriesIndex = SeriesIndex + 1;
                }
                return 0;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enableDebugWindow = checkBoxDebugEnable.Checked;
            outputFile = new StreamWriter(Path.Combine(mydocpath, "WriteLines.txt"));
            PrintDebug(3, "Program starting");
            PrintDebug(3, "Log file directory:" + mydocpath);
            updateConnectionType("");
        }

        private void PrintDebug(int debugLevel,string dbgString)
        {
            if(this.InvokeRequired)
            {
                PrintDebugCallback d = new PrintDebugCallback(PrintDebug);
                this.Invoke(d, new object[] { debugLevel ,dbgString});
            }
            else
            {
                    if (debugLevel == 8)
                    {
                        debugTextBox.AppendText(DateTime.Now + "RAW :"); // + dbgString + "\n");
                        foreach (var item in dbgString)
                        {
                            debugTextBox.AppendText(dbgString);
                        }
                        debugTextBox.AppendText(Environment.NewLine);
                    }
                    if(masterDebugLevel >= debugLevel)
                    {
                        debugTextBox.AppendText(DateTime.Now + "(" + DateTime.Now.Ticks + ")" + ":" + dbgString.Replace("\r\n", "<\\r\\n>") + Environment.NewLine);
                        if (enableFileLogging == true)
                        {
                            try
                            {
                                // Write the string array to a new file named "WriteLines.txt".
                                outputFile.WriteLine(DateTime.Now + ":" + dbgString);
                                outputFile.Flush();
                            }
                            catch (Exception ex)
                            {
                                debugTextBox.AppendText(DateTime.Now + ":" + "Log file write exception:" + ex + Environment.NewLine);
                            }
                        }
                        debugTextBox.ScrollToCaret();
                }
                    
            }
            
        }
        private void ProcessData(string data)
        {
            if (this.InvokeRequired)
            {
                ProcessDataCallback d = new ProcessDataCallback(ProcessData);
                this.Invoke(d, new object[] { data });
            }
            else
            {
                PrintDebug(3, "ProcessData");
                if(checkBoxRawDebugEnable.Checked == true)
                {
                    PrintDebug(1, data);
                }
                
                //printDebug("", "Data length:" + data.Length);
                receivedDataString = receivedDataString + data;
                //printDebug("", "Received Data String Length:" + receivedDataString.Length);
                //if(data.EndsWith("\r\n")==false)
                //{
                //    printDebug("", "Bad packet.");
                //}
                bool packetsRemaining = true;

                while (packetsRemaining==true)
                {
                    int headerLocation = receivedDataString.IndexOf(headerMask);
                    int footerLocation = receivedDataString.IndexOf(footerMask, headerLocation + headerMask.Length);
                    if (headerLocation != footerLocation && headerLocation > 0 && footerLocation > 0)
                    {
                        //printDebug("", "Full packet found.");

                        //printDebug("", "Packet data:" + receivedDataString + "<END PACKET DATA>");
                        string packetString = receivedDataString.Substring(headerLocation + headerMask.Length, ((footerLocation ) - (headerLocation + headerMask.Length)));
                        
                        String[] packetDataValues = packetString.Split(',');
                        //PrintDebug(1, receivedDataString);
                        if(checkBoxRxTxLogEnable.Checked==true)
                        {
                            PrintDebug(1, "packetDataValues:" + packetDataValues[0] + "," + packetDataValues[1]);
                        }
                        dataSeries1.addData(packetDataValues, 2);
                        //printDebug("", "String length:" + value1.GetLength(0).ToString());
                        receivedDataString = receivedDataString.Remove(0, footerLocation - 1);
                        //receivedDataString = "";
                    }
                    else
                    {
                        //printDebug("", "No packet found. (" + headerLocation + "/" + footerLocation + ")");
                        packetsRemaining = false;
                    }
                    /*if (footerLocation > -1)
                    {

                        printDebug("", "Packet footer found@" + footerLocation);


                    }*/

            }
        }
                
        }

        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            /*private void button6_MouseClick(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Right)
                {
                    voltageValue = button6.Text;
                    new Form2().ShowDialog();
                    button6.Text = voltageValue;
                }
                if (e.Button == MouseButtons.Left)
                {
                    scpiSend("SOUR:VOLT " + button6.Text);
                }
            }*/
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void serialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateConnectionType("Serial");
        }

        private void tCPIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateConnectionType("TCPIP");
        }
        private void updateConnectionType(string connType)
        {
            
            
            if(connType.Length > 0)
            {
                PrintDebug(3, connType + " connection type selected.");
                connectionType = connType;
                connectionTypeComboBox.SelectedItem = connectionType;
            } else
            {
                connectionTypeComboBox.Items.Clear();
                connectionTypeComboBox.Items.AddRange(connectionTypeList);
                connectionTypeComboBox.SelectedItem = connectionType;
            }
            
        }

        private void connectionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void connectionTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (connectionTypeComboBox.SelectedIndex < 2 && connectionTypeComboBox.Text != connectionType)
            {
                updateConnectionType(connectionTypeComboBox.Text);
            }
            if (connectionTypeComboBox.SelectedIndex > 1)
            {
                PrintDebug(3, connectionTypeComboBox.Text+" not implemented.");
                connectionTypeComboBox.SelectedItem = connectionType;
            }
            
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            PrintDebug(1, "Attempting to connect to:" + remoteIPAddress + "@" + remotePort);
            try
            {
                networkSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // Have to reassign or error is thrown
                networkSocket.Connect(remoteIPAddress, remotePort);
            }
            catch(SocketException ex)
            {
                if (ex.ErrorCode == 10061)
                {
                    MessageBox.Show("Socket exception. Remote host refused connection." + ex.ErrorCode);
                    PrintDebug(1, "Socket exception. Remote host refused connection." + ex.ErrorCode);
                }
                
            }
            catch(Exception ex)
            {
                
                MessageBox.Show("Connect exception." + ex.ToString() + " Error Code ");

            }
            if (networkSocket.Connected)
            {
                PrintDebug(1, "Connected");
                UpdateControls(true);
                //Wait for data asynchronously
                WaitForData();
            } 
            
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            PrintDebug(1, "Attempting to disconnect");
            try
            {
                networkSocket.Shutdown(SocketShutdown.Both); // Have to Shutdown first or Disconnect hangs
                networkSocket.Disconnect(false);
                networkSocket.Close();
                networkSocket = null;
                PrintDebug(1, "networkSocket disconnected");
                UpdateControls(false);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Disconnecting exception."+ex.ToString());
            }
                
        }

        public void WaitForData()
        {
            if (networkSocket != null)
            {
                try
                {
                    if (m_pfnCallBack == null)
                    {
                        PrintDebug(3, "Creating m_pfnCallBack");
                        m_pfnCallBack = new AsyncCallback(OnDataReceived);
                    }
                    PrintDebug(3, "WaitForData");
                    SocketPacket theSocPkt = new SocketPacket();
                    theSocPkt.thisSocket = networkSocket;
                    // Start listening to the data asynchronously
                    m_result = networkSocket.BeginReceive(theSocPkt.dataBuffer,
                                                            0, theSocPkt.dataBuffer.Length,
                                                            SocketFlags.None,
                                                            m_pfnCallBack,
                                                            theSocPkt);
                }
                catch (SocketException se)
                {
                    MessageBox.Show("WaitForData exception:" + se.Message+"Error codes:"+se.ErrorCode);
                }
                catch (Exception ex)
                {
                    PrintDebug(1, "WaitForData exception:" + ex);
                }
            }

        }
        public class SocketPacket
        {
            public System.Net.Sockets.Socket thisSocket;
            public byte[] dataBuffer = new byte[1024];
        }
        public DataSeriesObject getDataSeries()
        {
            return dataSeries1;
        }
        public void OnDataReceived(IAsyncResult asyn)
        {
            try
            {
                PrintDebug(3, "OnDataReceived");
                SocketPacket theSockId = (SocketPacket)asyn.AsyncState;
                int iRx = theSockId.thisSocket.EndReceive(asyn);
                char[] chars = new char[iRx];
                System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
                int charLen = d.GetChars(theSockId.dataBuffer, 0, iRx, chars, 0);
                System.String szData = new System.String(chars);
                //printDebug("", szData);
                ProcessData(szData);
                if(networkSocket!=null && networkSocket.Connected)
                {
                    WaitForData();
                }
                
            }
            catch (ObjectDisposedException)
            {
                System.Diagnostics.Debugger.Log(0, "1", "\nOnDataReceived: Socket has been closed\n");
            }
            catch (SocketException se)
            {
                MessageBox.Show("onDataReceived exception:"+se.Message);
            }
        }
        private void UpdateControls(bool connected)
        {
            buttonConnect.Enabled = !connected;
            buttonDisconnect.Enabled = connected;
            //string connectStatus = connected ? "Connected" : "Not Connected";
            //PrintDebug(1, connectStatus);
        }
        void ButtonDisconnectClick(object sender, System.EventArgs e)
        {
            if (networkSocket != null)
            {
                networkSocket.Close();
                networkSocket = null;
                UpdateControls(false);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Dispose();
            //outputFile.Flush();
            outputFile.Close();
            //outputFile.Dispose();
        }

        private void buttonShowChart_Click(object sender, EventArgs e)
        {
            ChartWindow = new Form3(this);
            ChartWindow.Show();
            //ChartWindow.UpdateChart(dataSeries1);
        }

        private void checkBoxDebugEnable_CheckedChanged(object sender, EventArgs e)
        {
            enableDebugWindow = checkBoxDebugEnable.Checked;
        }

        private void numericUpDownDebugLevel_ValueChanged(object sender, EventArgs e)
        {
            masterDebugLevel = (int)numericUpDownDebugLevel.Value;
        }

        private void buttonClearDebugWindow_Click(object sender, EventArgs e)
        {
            debugTextBox.Clear();
        }
    }
}
