using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//利用Directory类和File类，删除指定目录下的全部文件。程序界面如图9-5所示，删除过程显示在ListBox控件中。
namespace ex9_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;					//被删除文件所在的路径
            string[] myfiles = Directory.GetFiles(path);	//获取指定路径下的全部文件
            for (int i = 0; i < myfiles.Length; i++)
            {
                File.Delete(myfiles[i]);					//删除指定的一个文件
                listBox1.Items.Add(myfiles[i] + "  被删除");
            }
            listBox1.Items.Add(path + "之下的文件已全部被删除");

        }
    }
}
