using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//使用foreach语句遍历字符串数组b中的每个元素，在窗体上按每行显示一个元素值的格式输出
//由于是利用foreach语句实现的数组遍历操作，所以不需要知道数组中元素的个数，也不需要显式地使用数组元素的下标来逐个指定它们的位置，显示内容在窗体上的标签控件label1中输出
namespace ex6_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            string[] b = { "篮球", "足球", "排球", "网球", "羽毛球", "乒乓球" };
            foreach (string str in b)
            {
                label1.Text += str + "\n";		//每行显示一个元素值
            }

        }
    }
}
