using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
// 创建可以用来编辑文本文件的简单文本编辑程序
namespace ex9_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string myfile;
        private void fileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();	//创建打开文件对话框实例
            openDialog.InitialDirectory = @"f:\temp";			//设置默认打开目录
            openDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            DialogResult result = openDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                myfile = openDialog.FileName;					//指定被打开的文件名
                StreamReader sr = new StreamReader(myfile, Encoding.Default);
                richTextBox1.Text = sr.ReadToEnd();				//完整读取文件内容
                sr.Close();									//关闭流对象
            }
        }

        private void fileSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();	//创建保存文件对话框实例
            saveDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            DialogResult result = saveDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                myfile = saveDialog.FileName; 					//指定被保存的文件名
                StreamWriter sw = new StreamWriter(myfile, false, Encoding.Default);
                sw.Write(richTextBox1.Text);					//写入流
                sw.Close();									//关闭流对象，写入到文件
            }
        }

        private void fileExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
