using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chapter6_9
{
    public partial class frmEx : Form
    {
        public frmEx()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       DateTime t;
       private const int TotalChars = 50;//可输入的字符数
        private void btnProduce_Click(object sender, EventArgs e)
        {
            int i, k;
            lblOrg.Text = "";
            Random ran = new Random();
            for (i = 0; i < TotalChars; i++)
            {
                k = ran.Next(0,26);
               // lblOrg .Text =lblOrg .Text +
            }
        }

        private void txtIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            int r, i;
            if (txtIn.Text.Length == TotalChars)
            {
                txtIn.Enabled = false;//不允许输入

            }

        }

       
    }
}
