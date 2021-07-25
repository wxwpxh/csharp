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
namespace ex9_10
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
            int count = (int)fs.Length;			//获取指定文件的字节长度
            Byte[] readstream = new Byte[count];	//根据文件长度创建数组readstream
            fs.Read(readstream, 0, count);		//把整个文件当成一个字节块读入数组
            for (int i = 0; i < count; i++)		//把数组readstream的内容显示到文本框内
            {
                richTextBox1.Text += (char)readstream[i];
            }
        }
    }
}
