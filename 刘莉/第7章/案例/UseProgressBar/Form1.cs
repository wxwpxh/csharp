using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            progressBar1.Maximum = 1000;
            progressBar2.Maximum = 100000;
            for (int i = 1; i <= 1000; i++)
            {
                for (int j = 1; j <= 100000; j++)
                {
                    if (j % 2000 == 0)
                        progressBar2.Value = j;
                }
                progressBar1.Value = i;
            }
            button1.Enabled = true;
        }
    }
}
