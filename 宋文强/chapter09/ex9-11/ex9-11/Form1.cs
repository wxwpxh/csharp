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
namespace ex9_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(textBox1.Text, FileMode.Append);
            String str = textBox2.Text;				//待写入的字符串
            ASCIIEncoding AE = new ASCIIEncoding();
            byte[] writestream = AE.GetBytes(str);  	//待写入字符串转换成字节数组
            for (int i = 0; i < str.Length; i++)
            {
                fs.WriteByte(writestream[i]);			//逐字节写入缓存区
            }
            fs.Close();								//关闭输出流，缓存数据写入文件
            textBox2.Text = "";						//清除已完成写入的字符串

        }
    }
}
