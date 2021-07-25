using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//在Windows窗体应用程序中删除字符串的前、后空格，并比较删除空格之后的字符串长度，结果在标签控件label1中输出
namespace ex5_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            string str1, str2, str3;
            str1 = "  体操";            //首端有2个空格
            str2 = "  运动员  ";        //首、尾端各有2个字符
            str3 = "  入场  ";          //首、尾端各有2个字符
            int length1 = str1.Length;
            int length2 = str2.Length;
            int length3 = str3.Length;
            label1.Text += str1 + str2 + str3 + "\n";
            label1.Text += "3个字符串的长度依次是：" + length1 + "  " + length2 + "  " + length3 + "\n\n";
            str1 = str1.TrimStart();    //删除首端空格，长度变为2
            str2 = str2.Trim();         //删除首、尾两端的空格，长度变为3
            str3 = str3.TrimEnd();      //删除尾部的空格，尾空格仍保留，长度变为4
            length1 = str1.Length;
            length2 = str2.Length;
            length3 = str3.Length;
            label1.Text += str1 + str2 + str3 + "\n";
            label1.Text += "3个字符串的长度依次是：" + length1 + "  " + length2 + "  " + length3 + "\n";

        }
    }
}
