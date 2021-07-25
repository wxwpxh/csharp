using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chapter6_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int sum = 1;
            for (int i = 1; i <= hScrollBar1.Value; i++)
                sum = sum * i;
            label2.Text = hScrollBar1.Value.ToString() + "!=" + sum.ToString();

        }
    }
}
