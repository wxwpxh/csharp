using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex3_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = double.Parse(textBox1.Text);     //把文本框中输入的字符串转换成数值
            double area = Math.PI * r * r;		        // Math.PI是系统定义的常数π
            label2.Text = String.Format("半径为 {0} 的圆面积 = {1:f2}", r, area);
        }
    }
}
