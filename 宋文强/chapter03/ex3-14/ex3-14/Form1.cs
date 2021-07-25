using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 在窗体上的文本框textBox1、textBox2、textBox3中分别用键盘输入一个数，然后单击按钮“判断”，利用条件运算符判断其中的最大值，并将最大值的位置显示在窗体上的标签label1中
分析：使用一次条件运算符，只能执行一次两个数值之间的比较，但可以嵌套使用条件运算符。为此，先进行a、b之间的比较，若a>b，则排除了b为最大值的可能，继续进行a、c之间的比较；若a>c，则确认a为最大值，否则c为最大值。若a、b之间比较的结果为a<b，则继续进行b、c之间的比较，从中找出最大值。
*/
namespace ex3_14
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
            string result;
            a = int.Parse(textBox1.Text);		//文本框内容为字符串，必须用Parse方法转换
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            result = a > b ? (a > c ? "左边" : "右边") : (b > c ? "中间" : "右边");
            label1.Text = "最大值的位置在" + result;

        }
    }
}
