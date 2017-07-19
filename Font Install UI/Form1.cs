using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Font_Install_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void googlep_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void Instagram_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void Twitter_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void Youtue_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void share_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }
    }
}
