using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exci13
{
    public partial class Form1 : Form
    {
        string[] name = new string[3] { "王华", "陈兵", "李强" };
        float[] score = new float[3] { 98.5f, 67.4f, 88.6f };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            i = int.Parse(textBox1.Text);
            try
            {
                textBox2.Text = name[i];
                textBox3.Text = score[i].ToString();
            }
            catch (Exception ex)
            {
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("输入的序号不正确");
            }
        }
    }
}
