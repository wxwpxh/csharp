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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader f;
            string path = @"D:\C#编程题\ch12\myfile.txt";
            f = new StreamReader(path);
            textBox1.Text = f.ReadToEnd();
            f.Close();
        }
    }
}
