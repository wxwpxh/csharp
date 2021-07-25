using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//利用String对象的Split()方法，把文本框textBox1中出现的所有英文单词首字母转换为大写
namespace ex6_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();  //先把输入文章前后的空格去掉
            string[] a = textBox1.Text.Split(' ');			//以空格作为分界符进行切分
            textBox1.Text = "";
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                string a1 = a[i].Substring(0, 1).ToUpper();	//把单词首字母转换成大写
                textBox1.Text += a1 + a[i].Substring(1) + " ";
            }

        }
    }
}
