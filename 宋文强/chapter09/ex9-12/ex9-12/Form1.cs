using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text;
//使用StreamReader对象读取指定绝对路径的包含汉字信息的文本文件，并在窗体上的文本框内显示文件的全部内容
namespace ex9_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(textBox1.Text, Encoding.Default);
                richTextBox1.Text = sr.ReadToEnd();		//一次性读取整个文件的全部字符
            }
            catch
            {
                MessageBox.Show("文件打不开或者文件不存在", "文件打开错误",    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
