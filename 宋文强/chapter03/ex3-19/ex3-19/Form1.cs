using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * 编程判断一个任意正整数x是否为素数（或称质数）。
分析：按照素数的定义，除了1和它自身以外，不能被其它数整除的数即为素数。但数学上可以证明，只要小于 的所有整数均不能将其整除，即可确认x为素数。因此可以采用枚举法，用2到 之间的所有整数逐个作为除数，判断x能否被整除。对于这样的问题求解，使用循环结构也是非常有效的
*/
namespace ex3_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Click(object sender, EventArgs e)
        {
            double x, n;
            bool t = true;
            x = double.Parse(textBox1.Text);	//将文本框中输入的内容转换为数值赋给x
            n = Math.Sqrt(x);
            for (int i = 2; i <= n; i++) 		//用2到 之间的所有整数逐个作为除数
                if (x % i == 0) t = false;	//如果不是素数，变量t赋值为false
            if (t == true)
                label2.Text = textBox1.Text + "是一个素数";
            else
                label2.Text = textBox1.Text + "不是素数";
        }
    }
}
