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

namespace exci12
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\C#编程题\ch12\myfile.dat";
            if (!File.Exists(path)) //不存在该文件时
                textBox1.Text = "指定的文件不存在";
            else
            {
                FileStream f = File.OpenRead(path);
                BinaryReader sb = new BinaryReader(f);
                string mystr = "";
                string name = "";
                float score = 0;
                int i;
                float s = 0;
                for (i = 0; i <= 2; i++)
                {
                    name = sb.ReadString();
                    score = sb.ReadSingle();
                    s = s + score;
                    mystr = mystr + string.Format("{0}\t{1}\r\n", name, score);
                }
                textBox1.Text = mystr;
                textBox2.Text = string.Format("{0}", s / 3);
                sb.Close();
                f.Close();
            }
        }
    }
}
