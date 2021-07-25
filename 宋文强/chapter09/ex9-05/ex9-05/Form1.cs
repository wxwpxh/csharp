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
namespace ex9_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo path = new DirectoryInfo(textBox1.Text);
                if (path.Exists)
                {
                    path.Delete();				//若指定的目录不为空，则删除时出错
                    //path.Delete(true);			//无论指定的目录是否为空，均可删除
                    label1.Text = "目录已存在，予以删除！";
                }
                path.Create();					//创建目录
            }
            catch (Exception ex) 					//捕捉程序异常，报告错误信息
            {
                label1.Text = "程序异常：" + ex.ToString();
            }

        }
    }
}
