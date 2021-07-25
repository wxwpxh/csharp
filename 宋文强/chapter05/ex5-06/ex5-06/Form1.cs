using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//在Windows窗体应用程序中计算给定字符串的长度，结果通过标签控件label1输出
namespace ex5_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            string str1, str2;
            str1 = "理想的书籍是智慧的钥匙";		//字符串完全由中文字符组成
            str2 = "北京奥运会100米冠军Bolt";		//字符串由中文、英文和数字组成
            int length1 = str1.Length;
            int length2 = str2.Length;
            label1.Text += "第一个字符串的长度：" + length1 + "\n";
            label1.Text += "第二个字符串的长度：" + length2 + "\n";

        }
    }
}
