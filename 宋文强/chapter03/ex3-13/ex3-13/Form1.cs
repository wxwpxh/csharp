using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex3_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(textBox1.Text);
            label1.Text = x >= 0 ? "您输入的是正数" : "您输入的是负数";

            ////第二种写法
            //if (x >= 0)
            //    label1.Text = "您输入的是正数";
            //else
            //    label1.Text = "您输入的是负数";

        }
    }
}
