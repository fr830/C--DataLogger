using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLogger
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.connectionType == "Serial")
            {
                tabControl1.SelectedTab = tabPageSerial;
            }
            if (Form1.connectionType == "TCPIP")
            {
                tabControl1.SelectedTab = tabPageTCPIP;
            }
        }
    }
}
