using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//在Windows窗体应用程序中截取一个字符串中的若干字符构成子串，并将子串构成新的字符串，结果在标签控件label1中输出
namespace ex5_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            string str1, str2, str3, str4;
            str1 = "大熊猫团团、圆圆踏上宝岛";
            str2 = str1.Substring(3, 2);
            str3 = str1.Substring(6, 2);
            str4 = str1.Substring(9);
            label1.Text += str2 + str3 + str4 + "\n";

        }
    }
}
