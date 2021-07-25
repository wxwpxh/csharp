using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex3_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            string result = "最大值的位置在";
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            if (a > b)
            {
                if (a > c)
                    result += "左边";
                else
                    result += "右边";
            }
            else
            {
                if (b > c)
                    result += "中间";
                else
                    result += "右边";
            }
            label1.Text = result;

        }
    }
}
