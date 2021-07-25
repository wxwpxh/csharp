using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 编程计算任意正整数n的阶乘。
分析：根据阶乘的定义，可以写成表达式n! = 1 * 2 * 3 * … * n ，这样的问题适合于利用for语句来求解。
编写计算阶乘的程序时，需要用到两个变量，一个用来逐次表示1~n的每个数，另一个用来存放计算阶乘的结果。当然，用来存放阶乘结果的变量应赋初值为1。

 */
namespace ex3_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int f = 1, n = 8;					//变量f用来保存计算阶乘的结果，初值应为1
            for (int i = 1; i <= n; i++)
                f *= i;						//计算阶乘
            label1.Text = n.ToString() + "！= " + f.ToString();

        }
    }
}
