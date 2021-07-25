using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//在Windows窗体应用程序中查看一个字符串是否由指定的子串开头或结尾，确定字符串中指定的子串是否存在，若存在则指出该子串第一次出现或最后一次出现的位置，结果在标签控件label1中输出
namespace ex5_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            string str1;
            str1 = "大熊猫团团、圆圆踏上宝岛";
            int pos1 = str1.IndexOf("团团");
            int pos2 = str1.LastIndexOf("圆圆");
            bool b1 = str1.StartsWith("熊猫");
            bool b2 = str1.EndsWith("宝岛");
            label1.Text += "团团在语句中首次出现的位置是：" + pos1 + "\n";
            label1.Text += "圆圆在语句中最后一次出现的位置是：" + pos2 + "\n";
            if (b1 != true) label1.Text += "本语句不以熊猫开头\n";
            if (b2 != true) label1.Text += "本语句不以宝岛结束";

        }
    }
}
