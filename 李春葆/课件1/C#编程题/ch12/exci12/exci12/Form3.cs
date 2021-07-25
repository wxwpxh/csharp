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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\C#编程题\ch12\myfile.dat";
            FileStream f = File.OpenWrite(path);
            BinaryWriter sb = new BinaryWriter(f);
            int i;
            string[] name = new string[3] { "王华", "孙强", "成功" };
            float[] score = new float[3] { 78.5f, 88.6f, 98.5f };
            for (i = 0; i <= 2; i++)
            {
                sb.Write(name[i]);
                sb.Write(score[i]);
            }
            sb.Close();
            f.Close();
        }
    }
}
