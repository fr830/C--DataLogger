namespace DataLogger
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSerial = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.portClose = new System.Windows.Forms.Button();
            this.portOpen = new System.Windows.Forms.Button();
            this.comboBoxPortList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.checkBoxSendNewLine = new System.Windows.Forms.CheckBox();
            this.tabPageSCPI = new System.Windows.Forms.TabPage();
            this.buttonCloseVisaDevice = new System.Windows.Forms.Button();
            this.buttonConnectVisaDevice = new System.Windows.Forms.Button();
            this.comboBoxVisaDevices = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonGetVisaDevices = new System.Windows.Forms.Button();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.buttonSelectOutputFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPageAutomation = new System.Windows.Forms.TabPage();
            this.tabPageTCPIP = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageSerial.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageSCPI.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSerial);
            this.tabControl1.Controls.Add(this.tabPageSCPI);
            this.tabControl1.Controls.Add(this.tabPageOptions);
            this.tabControl1.Controls.Add(this.tabPageAutomation);
            this.tabControl1.Controls.Add(this.tabPageTCPIP);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 438);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPageSerial
            // 
            this.tabPageSerial.Controls.Add(this.groupBox1);
            this.tabPageSerial.Controls.Add(this.portClose);
            this.tabPageSerial.Controls.Add(this.portOpen);
            this.tabPageSerial.Controls.Add(this.comboBoxPortList);
            this.tabPageSerial.Controls.Add(this.label1);
            this.tabPageSerial.Controls.Add(this.button2);
            this.tabPageSerial.Controls.Add(this.button3);
            this.tabPageSerial.Controls.Add(this.sendTextBox);
            this.tabPageSerial.Controls.Add(this.checkBoxSendNewLine);
            this.tabPageSerial.Location = new System.Drawing.Point(4, 25);
            this.tabPageSerial.Name = "tabPageSerial";
            this.tabPageSerial.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSerial.Size = new System.Drawing.Size(546, 409);
            this.tabPageSerial.TabIndex = 0;
            this.tabPageSerial.Text = "Serial Port";
            this.tabPageSerial.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(30, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 215);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Configuration";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "None",
            "RequestToSend",
            "RequestToSendXOnXoff",
            "XOnXOff"});
            this.comboBox6.Location = new System.Drawing.Point(120, 153);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(101, 24);
            this.comboBox6.TabIndex = 13;
            this.comboBox6.Text = "None";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(120, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(101, 24);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Text = "9600";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Even",
            "Mark",
            "None",
            "Odd",
            "Space"});
            this.comboBox5.Location = new System.Drawing.Point(120, 123);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(101, 24);
            this.comboBox5.TabIndex = 12;
            this.comboBox5.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Flow Control";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBox4.Location = new System.Drawing.Point(120, 93);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(101, 24);
            this.comboBox4.TabIndex = 11;
            this.comboBox4.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBox3.Location = new System.Drawing.Point(120, 63);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(101, 24);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.Text = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stop Bits";
            // 
            // portClose
            // 
            this.portClose.Location = new System.Drawing.Point(180, 62);
            this.portClose.Name = "portClose";
            this.portClose.Size = new System.Drawing.Size(75, 23);
            this.portClose.TabIndex = 14;
            this.portClose.Text = "Close";
            this.portClose.UseVisualStyleBackColor = true;
            // 
            // portOpen
            // 
            this.portOpen.Location = new System.Drawing.Point(99, 62);
            this.portOpen.Name = "portOpen";
            this.portOpen.Size = new System.Drawing.Size(75, 23);
            this.portOpen.TabIndex = 0;
            this.portOpen.Text = "Connect";
            this.portOpen.UseVisualStyleBackColor = true;
            // 
            // comboBoxPortList
            // 
            this.comboBoxPortList.FormattingEnabled = true;
            this.comboBoxPortList.Location = new System.Drawing.Point(99, 16);
            this.comboBoxPortList.Name = "comboBoxPortList";
            this.comboBoxPortList.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPortList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Com Port";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(415, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 27);
            this.button3.TabIndex = 11;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // sendTextBox
            // 
            this.sendTextBox.Location = new System.Drawing.Point(30, 107);
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(257, 22);
            this.sendTextBox.TabIndex = 10;
            // 
            // checkBoxSendNewLine
            // 
            this.checkBoxSendNewLine.AutoSize = true;
            this.checkBoxSendNewLine.Location = new System.Drawing.Point(293, 108);
            this.checkBoxSendNewLine.Name = "checkBoxSendNewLine";
            this.checkBoxSendNewLine.Size = new System.Drawing.Size(116, 21);
            this.checkBoxSendNewLine.TabIndex = 15;
            this.checkBoxSendNewLine.Text = "Send Newline";
            this.checkBoxSendNewLine.UseVisualStyleBackColor = true;
            // 
            // tabPageSCPI
            // 
            this.tabPageSCPI.Controls.Add(this.buttonCloseVisaDevice);
            this.tabPageSCPI.Controls.Add(this.buttonConnectVisaDevice);
            this.tabPageSCPI.Controls.Add(this.comboBoxVisaDevices);
            this.tabPageSCPI.Controls.Add(this.label8);
            this.tabPageSCPI.Controls.Add(this.buttonGetVisaDevices);
            this.tabPageSCPI.Location = new System.Drawing.Point(4, 25);
            this.tabPageSCPI.Name = "tabPageSCPI";
            this.tabPageSCPI.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSCPI.Size = new System.Drawing.Size(546, 409);
            this.tabPageSCPI.TabIndex = 1;
            this.tabPageSCPI.Text = "SCPI";
            this.tabPageSCPI.UseVisualStyleBackColor = true;
            // 
            // buttonCloseVisaDevice
            // 
            this.buttonCloseVisaDevice.Location = new System.Drawing.Point(228, 95);
            this.buttonCloseVisaDevice.Name = "buttonCloseVisaDevice";
            this.buttonCloseVisaDevice.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseVisaDevice.TabIndex = 19;
            this.buttonCloseVisaDevice.Text = "Close";
            this.buttonCloseVisaDevice.UseVisualStyleBackColor = true;
            // 
            // buttonConnectVisaDevice
            // 
            this.buttonConnectVisaDevice.Location = new System.Drawing.Point(147, 95);
            this.buttonConnectVisaDevice.Name = "buttonConnectVisaDevice";
            this.buttonConnectVisaDevice.Size = new System.Drawing.Size(75, 23);
            this.buttonConnectVisaDevice.TabIndex = 15;
            this.buttonConnectVisaDevice.Text = "Connect";
            this.buttonConnectVisaDevice.UseVisualStyleBackColor = true;
            // 
            // comboBoxVisaDevices
            // 
            this.comboBoxVisaDevices.FormattingEnabled = true;
            this.comboBoxVisaDevices.Location = new System.Drawing.Point(26, 49);
            this.comboBoxVisaDevices.Name = "comboBoxVisaDevices";
            this.comboBoxVisaDevices.Size = new System.Drawing.Size(372, 24);
            this.comboBoxVisaDevices.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Device";
            // 
            // buttonGetVisaDevices
            // 
            this.buttonGetVisaDevices.Location = new System.Drawing.Point(416, 49);
            this.buttonGetVisaDevices.Name = "buttonGetVisaDevices";
            this.buttonGetVisaDevices.Size = new System.Drawing.Size(75, 23);
            this.buttonGetVisaDevices.TabIndex = 18;
            this.buttonGetVisaDevices.Text = "Refresh";
            this.buttonGetVisaDevices.UseVisualStyleBackColor = true;
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.Controls.Add(this.buttonSelectOutputFile);
            this.tabPageOptions.Controls.Add(this.textBox1);
            this.tabPageOptions.Controls.Add(this.checkBox1);
            this.tabPageOptions.Location = new System.Drawing.Point(4, 25);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Size = new System.Drawing.Size(546, 409);
            this.tabPageOptions.TabIndex = 2;
            this.tabPageOptions.Text = "Options";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // buttonSelectOutputFile
            // 
            this.buttonSelectOutputFile.Location = new System.Drawing.Point(371, 53);
            this.buttonSelectOutputFile.Name = "buttonSelectOutputFile";
            this.buttonSelectOutputFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectOutputFile.TabIndex = 2;
            this.buttonSelectOutputFile.Text = "Select";
            this.buttonSelectOutputFile.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 22);
            this.textBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(43, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Output File";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPageAutomation
            // 
            this.tabPageAutomation.Location = new System.Drawing.Point(4, 25);
            this.tabPageAutomation.Name = "tabPageAutomation";
            this.tabPageAutomation.Size = new System.Drawing.Size(546, 409);
            this.tabPageAutomation.TabIndex = 3;
            this.tabPageAutomation.Text = "Automation";
            this.tabPageAutomation.UseVisualStyleBackColor = true;
            // 
            // tabPageTCPIP
            // 
            this.tabPageTCPIP.Location = new System.Drawing.Point(4, 25);
            this.tabPageTCPIP.Name = "tabPageTCPIP";
            this.tabPageTCPIP.Size = new System.Drawing.Size(546, 409);
            this.tabPageTCPIP.TabIndex = 4;
            this.tabPageTCPIP.Text = "TCP/IP";
            this.tabPageTCPIP.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 452);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSerial.ResumeLayout(false);
            this.tabPageSerial.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageSCPI.ResumeLayout(false);
            this.tabPageSCPI.PerformLayout();
            this.tabPageOptions.ResumeLayout(false);
            this.tabPageOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSCPI;
        private System.Windows.Forms.Button buttonCloseVisaDevice;
        private System.Windows.Forms.Button buttonConnectVisaDevice;
        private System.Windows.Forms.ComboBox comboBoxVisaDevices;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonGetVisaDevices;
        private System.Windows.Forms.TabPage tabPageSerial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button portClose;
        private System.Windows.Forms.Button portOpen;
        private System.Windows.Forms.ComboBox comboBoxPortList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.CheckBox checkBoxSendNewLine;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.Button buttonSelectOutputFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPageAutomation;
        private System.Windows.Forms.TabPage tabPageTCPIP;
    }
}