using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 例8._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            //设置打开的文件为.txt格式
            openFileDialog1.Filter = "文本文件(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               Content.Text = string.Empty;
                //获取“打开”对话框中选择的文件名
               string path = openFileDialog1.FileName;
               //实例化StreamReader对象
               //StreamReader sr = new StreamReader(path, Encoding.Default);
               StreamReader sr = new StreamReader(path);
               Content.Text = sr.ReadToEnd();
                sr.Close();//关闭当前流
            }
        }

        private void Write_Click(object sender, EventArgs e)
        {
            if (Content.Text == string.Empty)
            {
                MessageBox.Show("文件内容不能为空！");
            }
            else
            {
                saveFileDialog1.Filter = "文本文件(*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //使用另存为对话框输入的文件名来实例化StreamWriter对象
                    StreamWriter sw = new StreamWriter(saveFileDialog1 .FileName );
                    sw.Write(Content .Text );
                    sw.Close();
                }                
            }
        }

        private void Content_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
