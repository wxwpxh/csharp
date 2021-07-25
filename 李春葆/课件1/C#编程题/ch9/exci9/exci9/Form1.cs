using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exci9
{
    public partial class Form1 : Form
    {
        int n = 0;   //保存用户错误输入的次数
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234" && textBox2.Text == "1234")
            {
                MessageBox.Show("用户名/口令正确");
                this.Close();
                //调用其他程序
            }
            else
            {
                if (n < 3)
                {
                    MessageBox.Show("用户名/口令错误,再次输入");
                    n++;
                }
                else
                {
                    MessageBox.Show("已经错误输入三次，退出");
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
