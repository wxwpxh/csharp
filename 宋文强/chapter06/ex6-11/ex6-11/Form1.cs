using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//将字符数组english中第10个元素开始的连续10个元素内容予以清除（char类型变量的默认初值为'\0'）。
namespace ex6_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "大写英文字母表：\n";
            char[] english = new char[26];
            for (int i = 0; i < 26; i++)
            {
                english[i] = (char)(i + 65);
                label1.Text += english[i] + " ";
            }
            label1.Text += "\n\n清除部分内容以后：\n";
            Array.Clear(english, 10, 10);			//从数组中第10个元素开始，清除10个元素
            for (int i = 0; i < 26; i++)
            {
                if (english[i] == '\0')			//如果数组元素被清除，显示“*”
                    label1.Text += "* ";
                else
                    label1.Text += english[i] + " ";
            }

        }
    }
}
