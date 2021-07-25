using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//利用FileInfo类实现的文件复制操作
namespace ex9_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool overwrite = true;                      	//目标文件已存在时，允许覆盖
            try
            {
                FileInfo file1 = new FileInfo(textBox1.Text);//源文件实例对象
                file1.CopyTo(textBox2.Text, overwrite);    	//执行文件复制操作
            }
            catch (Exception ex) 						//捕捉程序异常，报告错误信息
            {
                MessageBox.Show(ex.ToString(), "文件操作错误");
            }

        }
    }
}
