using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//利用FileStream对象的ReadByte()方法读取字节，并在文本框中显示文件内容。
namespace ex9_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(textBox1.Text, FileMode.Open);
            richTextBox1.Text = "";
            for (int i = 0; i < fs.Length; i++)		//fs.Length表示了文件的字节长度
            {
                richTextBox1.Text += (char)fs.ReadByte();//读取一个字节并强制进行类型转换
            }
        }
    }
}
