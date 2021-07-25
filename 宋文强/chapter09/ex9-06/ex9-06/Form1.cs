using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//利用Directory类，按用户在文本框textBox1中指定的路径创建目录。若目录已存在，则先予以删除，再重新创建。
namespace ex9_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;			//文件框textBox1中输入被查看目录名
            if (Directory.Exists(path))			//如果被查看的目录存在
            {						//指定目录下的文件名和目录名保存到名为dir的数组中
                string[] dir = Directory.GetFileSystemEntries(path);
                //string[] dir = Directory.GetFiles(path);	//只查看文件名
                //string[] dir = Directory.Directories(path);//只查看目录名
                listBox1.Items.Clear();			//清除列表框中的现有内容
                listBox1.Items.AddRange(dir);		//把数组dir的内容全部添加到列表框中

            }
        }
    }
}
