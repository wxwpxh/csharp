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
namespace ex9_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo source = new DirectoryInfo(textBox1.Text);		//源文件夹
            DirectoryInfo destination = new DirectoryInfo(textBox2.Text);	//目标文件夹
            if (!destination.Exists)					//判断指定的目标目录是否存在
                destination.Create();					//若指定目标目录不存在，则创建目录
            foreach (FileInfo f in source.GetFiles())	//遍历源文件夹
            {
                f.CopyTo(destination.FullName + "\\" + f.Name, true);
                listBox1.Items.Add(f.Name + "  被复制\n");
            }
            listBox1.Items.Add("复制完成");

        }
    }
}
