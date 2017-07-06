using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwearGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            SwearGenerator.GlobalVars.generateStatus = "Idle - Waiting";

        }

        private void checkMultiple_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMultiple.Checked == true)
            {
                numericMultiple.Enabled = true;
            }
            else
            {
                numericMultiple.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkMultiple.Checked == false)
            {
                Form browser = new WebBrowser(checkClipboard.Checked, 1);
                if (checkDebug.Checked == true) { browser.Show(); }
                else { browser.Show(); browser.Visible = false; }
                }
            else
            {
                Form browser = new WebBrowser(checkClipboard.Checked, (int) numericMultiple.Value);
                if (checkDebug.Checked == true) { browser.Show(); }
                else { browser.Show(); browser.Visible = false; }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = SwearGenerator.GlobalVars.generateStatus;
        }
    }
}
