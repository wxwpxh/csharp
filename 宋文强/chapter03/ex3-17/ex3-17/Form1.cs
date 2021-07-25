using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
  编程计算100以内（包括100）所有自然数的累加和。
分析：象这样简单的累加和求解问题，可以利用表达式s = 1+2+3+…+99+100 计算，但这样一来计算表达式将极为冗长，而且这样的计算程序也缺乏通用性（当然，这样的问题可以利用高斯公式计算，并不复杂，这里只是举例而已）。如果计算规模稍有变化，程序代码就得重写。利用循环结构，可以高效率地写出具有良好通用性的计算程序。
编写计算累加和的程序时，需要用到两个变量，一个用来逐次表示100以内的每个自然数，另一个用来存放计算累加和的结果。当然，用来存放累加和的变量应赋初值为0。

 */
namespace ex3_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = 0;						//变量s用来保存累加和，初值应为0
            for (int i = 1; i <= 100; i++)
                s += i;						//累加计算
            label1.Text = "1-100的累加和 = " + s;

        }
    }
}
