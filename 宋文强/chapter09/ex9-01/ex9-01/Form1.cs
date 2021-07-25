using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//利用FileInfo类的实例属性，查看指定文件的基本信息。
namespace ex9_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();	//创建打开文件对话框的实例
            DialogResult result = openFile.ShowDialog();	//获取对话框工作状态
            if (result == DialogResult.OK)
            {
                FileInfo info = new FileInfo(openFile.FileName);	//创建FileInfo的实例
                richTextBox1.Text += "文件名称：" + info.Name + "\n";
                richTextBox1.Text += "完整路径：" + info.FullName + "\n";
                richTextBox1.Text += "文件长度：" + info.Length + "\n";
                richTextBox1.Text += "创建时间：" + info.CreationTime + "\n";
                richTextBox1.Text += "上次访问时间：" + info.LastAccessTime + "\n";
                richTextBox1.Text += "上次写入时间：" + info.LastWriteTime + "\n";
                richTextBox1.Text += "文件基本属性：" + info.Attributes + "\n";
            }

        }
    }
}
