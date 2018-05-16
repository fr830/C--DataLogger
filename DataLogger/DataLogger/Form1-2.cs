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

namespace DataLogger
{
    public partial class Form1 : Form
    {
        public static string connectionType = "TCPIP";
        string[] connectionTypeList = { "Serial", "TCPIP", "UDP", "WEB" };
        string remoteIPAddress = "127.0.0.1";
        UInt16 remotePort = 5005;
        Socket networkSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //TcpClient tcpClient;
        //NetworkStream networkStream; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            printDebug("", "Program starting");
            updateConnectionType("");
        }
        private void printDebug(string type, string dbgString)
        {
            debugTextBox.AppendText(DateTime.Now+":"+dbgString+"\n");
            debugTextBox.ScrollToCaret();
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
        // State object for receiving data from remote device.  
        public class StateObject
        {
            // Client socket.  
            public Socket workSocket = null;
            // Size of receive buffer.  
            public const int BufferSize = 256;
            // Receive buffer.  
            public byte[] buffer = new byte[BufferSize];
            // Received data string.  
            public StringBuilder sb = new StringBuilder();
        }
        // The port number for the remote device.  
        //private const int port = 11000;
        private const int port = 5005;
        // ManualResetEvent instances signal completion.  
        private static ManualResetEvent connectDone =
            new ManualResetEvent(false);
        private static ManualResetEvent sendDone =
            new ManualResetEvent(false);
        private static ManualResetEvent receiveDone =
            new ManualResetEvent(false);
        // The response from the remote device.  
        private static String response = String.Empty;

        private static void StartClient()
        {
            // Connect to a remote device.
            try
            {
                // Establish the remote endpoint for the socket.  
                // The name of the   
                // remote device is "host.contoso.com".  
                //IPHostEntry ipHostInfo = Dns.GetHostEntry("host.contoso.com");
                IPHostEntry ipHostInfo = Dns.GetHostByAddress("127.0.0.1");
                //IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

                // Create a TCP/IP socket.  
                Socket client = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect to the remote endpoint.  
                client.BeginConnect(remoteEP,
                    new AsyncCallback(ConnectCallback), client);
                connectDone.WaitOne();

                // Send test data to the remote device.  
                Send(client, "This is a test<EOF>");
                sendDone.WaitOne();

                // Receive the response from the remote device.  
                Receive(client);
                //receiveDone.WaitOne();

                // Write the response to the console. 
 
                Console.WriteLine("Response received : {0}", response);

                // Release the socket.  
                client.Shutdown(SocketShutdown.Both);
                client.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket client = (Socket)ar.AsyncState;

                // Complete the connection.  
                client.EndConnect(ar);

                Console.WriteLine("Socket connected to {0}",
                    client.RemoteEndPoint.ToString());

                // Signal that the connection has been made.  
                connectDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void Receive(Socket client)
        {
            try
            {
                // Create the state object.  
                StateObject state = new StateObject();
                state.workSocket = client;

                // Begin receiving the data from the remote device.  
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReceiveCallback), state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the state object and the client socket   
                // from the asynchronous state object.  
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;

                // Read data from the remote device.  
                int bytesRead = client.EndReceive(ar);

                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.  
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                    // Get the rest of the data.  
                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(ReceiveCallback), state);
                }
                else
                {
                    // All the data has arrived; put it in response.  
                    if (state.sb.Length > 1)
                    {
                        response = state.sb.ToString();
                    }
                    // Signal that all bytes have been received.
                    
                    receiveDone.Set();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void Send(Socket client, String data)
        {
            // Convert the string data to byte data using ASCII encoding.  
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.  
            client.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), client);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket client = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.  
                int bytesSent = client.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to server.", bytesSent);

                // Signal that all bytes have been sent.  
                sendDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
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
                printDebug("", connType + " connection type selected.");
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
                printDebug("", connectionTypeComboBox.Text+" not implemented.");
                connectionTypeComboBox.SelectedItem = connectionType;
            }
            
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            printDebug("", "Attempting to connect to:" + remoteIPAddress + "@" + remotePort);
            try
            {
                //networkSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // Have to reassign or error is thrown
                //networkSocket.Connect(remoteIPAddress, remotePort);
                StartClient();
            }
            catch(SocketException ex)
            {
                if (ex.ErrorCode == 10061)
                {
                    MessageBox.Show("Socket exception. Remote host refused connection." + ex.ErrorCode);
                }
                
            }
            catch(Exception ex)
            {
                
                MessageBox.Show("Connect exception." + ex.ToString() + " Error Code ");

            }
            printDebug("", "Connected");
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            printDebug("", "Attempting to disconnect");
            try
            {
                networkSocket.Shutdown(SocketShutdown.Both); // Have to Shutdown first or Disconnect hangs
                networkSocket.Disconnect(false);
                printDebug("", "networkSocket disconnected");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Disconnecting exception."+ex.ToString());
            }
                
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Dispose();
        }
    }
}
