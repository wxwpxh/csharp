using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex3_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            for(int i=1;i<=9;i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    label1.Text += i + "*" + j + "=" + i * j + "  ";
                }
                label1.Text += "\n";
            }
        }
    }
}
