using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//使用StreamWriter对象将字符串写入指定绝对路径的文本文件中。写入完成之后，清除richTextBox1中的内容，允许将新的字符串追加写入到文件中。
namespace ex9_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = textBox1.Text;
            StreamWriter sw = new StreamWriter(path, true);	//创建对象以追加方式写入文件
            sw.Write(richTextBox1.Text);					//把文本框内容写入文件
            sw.Close();									//关闭输出流
            richTextBox1.Text = "";						//清空文本框
        }
    }
}
