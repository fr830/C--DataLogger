namespace DataLogger
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.debugTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCPIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonShowChart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxDebugEnable = new System.Windows.Forms.CheckBox();
            this.checkBoxRxTxLogEnable = new System.Windows.Forms.CheckBox();
            this.checkBoxLogFileDebugEnable = new System.Windows.Forms.CheckBox();
            this.checkBoxRawDebugEnable = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownDebugLevel = new System.Windows.Forms.NumericUpDown();
            this.buttonClearDebugWindow = new System.Windows.Forms.Button();
            this.buttonShowRadarWindow = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDebugLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // debugTextBox
            // 
            this.debugTextBox.Location = new System.Drawing.Point(61, 394);
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.Size = new System.Drawing.Size(702, 94);
            this.debugTextBox.TabIndex = 0;
            this.debugTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Debug";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connect";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Disconnect";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Refresh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Connection Type";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Data Logger";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialToolStripMenuItem,
            this.tCPIPToolStripMenuItem,
            this.uDPToolStripMenuItem,
            this.webToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // serialToolStripMenuItem
            // 
            this.serialToolStripMenuItem.Name = "serialToolStripMenuItem";
            this.serialToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.serialToolStripMenuItem.Text = "Serial";
            this.serialToolStripMenuItem.Click += new System.EventHandler(this.serialToolStripMenuItem_Click);
            // 
            // tCPIPToolStripMenuItem
            // 
            this.tCPIPToolStripMenuItem.Name = "tCPIPToolStripMenuItem";
            this.tCPIPToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.tCPIPToolStripMenuItem.Text = "TCP/IP";
            this.tCPIPToolStripMenuItem.Click += new System.EventHandler(this.tCPIPToolStripMenuItem_Click);
            // 
            // uDPToolStripMenuItem
            // 
            this.uDPToolStripMenuItem.Name = "uDPToolStripMenuItem";
            this.uDPToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.uDPToolStripMenuItem.Text = "UDP";
            // 
            // webToolStripMenuItem
            // 
            this.webToolStripMenuItem.Name = "webToolStripMenuItem";
            this.webToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.webToolStripMenuItem.Text = "Web";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(125, 26);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // connectionTypeComboBox
            // 
            this.connectionTypeComboBox.FormattingEnabled = true;
            this.connectionTypeComboBox.Location = new System.Drawing.Point(183, 131);
            this.connectionTypeComboBox.Name = "connectionTypeComboBox";
            this.connectionTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.connectionTypeComboBox.TabIndex = 7;
            this.connectionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.connectionTypeComboBox_SelectedIndexChanged);
            this.connectionTypeComboBox.SelectedValueChanged += new System.EventHandler(this.connectionTypeComboBox_SelectedValueChanged);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(183, 40);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(100, 23);
            this.buttonConnect.TabIndex = 8;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(183, 69);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(100, 23);
            this.buttonDisconnect.TabIndex = 9;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(183, 98);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 23);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonShowChart
            // 
            this.buttonShowChart.Location = new System.Drawing.Point(322, 40);
            this.buttonShowChart.Name = "buttonShowChart";
            this.buttonShowChart.Size = new System.Drawing.Size(98, 23);
            this.buttonShowChart.TabIndex = 11;
            this.buttonShowChart.Text = "Show Chart";
            this.buttonShowChart.UseVisualStyleBackColor = true;
            this.buttonShowChart.Click += new System.EventHandler(this.buttonShowChart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Wait for complete packet";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(236, 191);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBoxDebugEnable
            // 
            this.checkBoxDebugEnable.AutoSize = true;
            this.checkBoxDebugEnable.Location = new System.Drawing.Point(117, 367);
            this.checkBoxDebugEnable.Name = "checkBoxDebugEnable";
            this.checkBoxDebugEnable.Size = new System.Drawing.Size(72, 21);
            this.checkBoxDebugEnable.TabIndex = 15;
            this.checkBoxDebugEnable.Text = "Debug";
            this.checkBoxDebugEnable.UseVisualStyleBackColor = true;
            this.checkBoxDebugEnable.CheckedChanged += new System.EventHandler(this.checkBoxDebugEnable_CheckedChanged);
            // 
            // checkBoxRxTxLogEnable
            // 
            this.checkBoxRxTxLogEnable.AutoSize = true;
            this.checkBoxRxTxLogEnable.Location = new System.Drawing.Point(195, 367);
            this.checkBoxRxTxLogEnable.Name = "checkBoxRxTxLogEnable";
            this.checkBoxRxTxLogEnable.Size = new System.Drawing.Size(61, 21);
            this.checkBoxRxTxLogEnable.TabIndex = 16;
            this.checkBoxRxTxLogEnable.Text = "RxTx";
            this.checkBoxRxTxLogEnable.UseVisualStyleBackColor = true;
            // 
            // checkBoxLogFileDebugEnable
            // 
            this.checkBoxLogFileDebugEnable.AutoSize = true;
            this.checkBoxLogFileDebugEnable.Location = new System.Drawing.Point(262, 367);
            this.checkBoxLogFileDebugEnable.Name = "checkBoxLogFileDebugEnable";
            this.checkBoxLogFileDebugEnable.Size = new System.Drawing.Size(136, 21);
            this.checkBoxLogFileDebugEnable.TabIndex = 17;
            this.checkBoxLogFileDebugEnable.Text = "Log debug to file";
            this.checkBoxLogFileDebugEnable.UseVisualStyleBackColor = true;
            // 
            // checkBoxRawDebugEnable
            // 
            this.checkBoxRawDebugEnable.AutoSize = true;
            this.checkBoxRawDebugEnable.Location = new System.Drawing.Point(404, 367);
            this.checkBoxRawDebugEnable.Name = "checkBoxRawDebugEnable";
            this.checkBoxRawDebugEnable.Size = new System.Drawing.Size(144, 21);
            this.checkBoxRawDebugEnable.TabIndex = 18;
            this.checkBoxRawDebugEnable.Text = "Show RAW debug";
            this.checkBoxRawDebugEnable.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Debug Level";
            // 
            // numericUpDownDebugLevel
            // 
            this.numericUpDownDebugLevel.Location = new System.Drawing.Point(164, 315);
            this.numericUpDownDebugLevel.Name = "numericUpDownDebugLevel";
            this.numericUpDownDebugLevel.Size = new System.Drawing.Size(53, 22);
            this.numericUpDownDebugLevel.TabIndex = 20;
            this.numericUpDownDebugLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDebugLevel.ValueChanged += new System.EventHandler(this.numericUpDownDebugLevel_ValueChanged);
            // 
            // buttonClearDebugWindow
            // 
            this.buttonClearDebugWindow.Location = new System.Drawing.Point(554, 348);
            this.buttonClearDebugWindow.Name = "buttonClearDebugWindow";
            this.buttonClearDebugWindow.Size = new System.Drawing.Size(130, 40);
            this.buttonClearDebugWindow.TabIndex = 21;
            this.buttonClearDebugWindow.Text = "Clear";
            this.buttonClearDebugWindow.UseVisualStyleBackColor = true;
            this.buttonClearDebugWindow.Click += new System.EventHandler(this.buttonClearDebugWindow_Click);
            // 
            // buttonShowRadarWindow
            // 
            this.buttonShowRadarWindow.Location = new System.Drawing.Point(322, 69);
            this.buttonShowRadarWindow.Name = "buttonShowRadarWindow";
            this.buttonShowRadarWindow.Size = new System.Drawing.Size(98, 23);
            this.buttonShowRadarWindow.TabIndex = 22;
            this.buttonShowRadarWindow.Text = "Show Radar";
            this.buttonShowRadarWindow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 521);
            this.Controls.Add(this.buttonShowRadarWindow);
            this.Controls.Add(this.buttonClearDebugWindow);
            this.Controls.Add(this.numericUpDownDebugLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxRawDebugEnable);
            this.Controls.Add(this.checkBoxLogFileDebugEnable);
            this.Controls.Add(this.checkBoxRxTxLogEnable);
            this.Controls.Add(this.checkBoxDebugEnable);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonShowChart);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.connectionTypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.debugTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDebugLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox debugTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tCPIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uDPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webToolStripMenuItem;
        private System.Windows.Forms.ComboBox connectionTypeComboBox;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonShowChart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBoxDebugEnable;
        private System.Windows.Forms.CheckBox checkBoxRxTxLogEnable;
        private System.Windows.Forms.CheckBox checkBoxLogFileDebugEnable;
        private System.Windows.Forms.CheckBox checkBoxRawDebugEnable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownDebugLevel;
        private System.Windows.Forms.Button buttonClearDebugWindow;
        private System.Windows.Forms.Button buttonShowRadarWindow;
    }
}

