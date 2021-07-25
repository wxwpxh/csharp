using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
// 利用File类实现的文件复制操作
namespace ex9_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool overwrite = true;                      //目标文件已存在时，允许覆盖
            string path1 = textBox1.Text;               //指定源文件的路径
            string path2 = textBox2.Text;               //指定目标文件的路径
            try
            {
                File.Copy(path1, path2, overwrite);     //执行文件复制操作
            }
            catch (Exception ex)						//捕捉程序异常，报告错误信息
            {
                MessageBox.Show(ex.ToString(), "文件操作错误");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
