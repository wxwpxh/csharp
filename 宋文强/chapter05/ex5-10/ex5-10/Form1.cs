using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//在Windows窗体应用程序中，向一个字符串先后插入、移除指定的子串，并用一个指定的字符，将字符串填充到指定的长度，结果在标签控件label1中输出
namespace ex5_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            string str1, str2, str3, str4, str5, str6;
            str1 = "大熊猫团团、圆圆踏上宝岛";
            int pos1 = str1.IndexOf("踏");		//确定“踏”字在str1中首次出现的位置
            str2 = "于今天下午17时";
            str3 = str1.Insert(pos1, str2);        //在str1中的“踏”字前面插入子串
            label1.Text += str3 + "\n";            //输出第1行
            int pos2 = str3.IndexOf("17时");		//在str3中确定“17时”首次出现的位置
            str4 = str3.Remove(pos2, 3);           //移除子串“17时”
            label1.Text += str4 + "\n";            //输出第2行
            str5 = str4.PadLeft(str3.Length, '*');  //左侧填充“*”号
            label1.Text += str5 + "\n";             //输出第3行
            str6 = str4.PadRight(str3.Length, '*'); //右侧填充“*”号
            label1.Text += str6 + "\n";             //输出第4行

        }
    }
}
