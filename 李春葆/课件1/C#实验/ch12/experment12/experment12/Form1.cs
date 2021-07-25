using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace experment12
{
    public partial class Form1 : Form
    {
        string path = @"D:\C#实验\ch12\student.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))  //不存在该文件,则创建
            {
                StreamWriter sw = File.CreateText(path);
                sw.Close();
            }
            if (textBox1.Text != "")
            {
                StreamWriter sb = new StreamWriter(path, true, Encoding.Default);
                sb.WriteLine(textBox1.Text);
                sb.WriteLine(textBox2.Text);
                sb.WriteLine(textBox3.Text);
                sb.WriteLine(textBox4.Text);
                sb.WriteLine(textBox5.Text);
                sb.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                button1.Enabled = false;
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            string mystr = "学号\t姓名\t性别\t年龄\t分数\r\n";
            FileStream fs = File.OpenRead(path);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            fs.Seek(0, SeekOrigin.Begin); 	//将文件流指针定位在开始位置
            while (sr.Peek() > -1)
            {
                for (i = 0; i < 5; i++)
                    mystr = mystr + sr.ReadLine() + "\t";
                mystr = mystr + "\r\n";  //\r\n表示回车换行
            }
            sr.Close();
            fs.Close();
            textBox6.Text = mystr;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
