using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex4_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "计算结果：\n";
            int n = int.Parse(textBox1.Text);
            for (int i = 1; i <= n; i++)
            {
                label2.Text += i.ToString() + "!=" + factorial(i) + "\n";
            }
        }
        public int factorial(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            else
                return num * factorial(num - 1);
        }
    }
}
