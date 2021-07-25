using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO ;

namespace 例8._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Read_Click(object sender, EventArgs e)
        {
            string path = fname .Text ;
            
            UTF8Encoding temp = new UTF8Encoding(true);
            int number;
            FileStream fs;
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);//以读操作形式打开流
            }
            catch 
            {

                MessageBox.Show("建立文件时出错。", "错误",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }
          
            string sRead = string.Empty;
            int i = 1;
            byte[] b = new byte[fs.Length ];
            try
            {
                //while ((number = fs.Read(b, 0, 6)) > 0)//每次从fs流中读取6个字节存到字节数组b从0开始的位置
                //{
                //    Console.WriteLine("第{0}次，当前开始的位置：{1}", i, fs.Position);
                //    content.Text += temp.GetString(b);//getstring不会去掉末尾的0，输出时显示为空格
                //    Console.WriteLine("----------{0}----------", sRead);
                //    Console.WriteLine("number=" + number);
                //    i++;
                //    b = new byte[6];
                //}
                fs.Read(b, 0, (int)fs.Length);
                content.Text = temp.GetString(b);
            }
            catch
            {

                MessageBox.Show("读取文件时出错。", "错误", System.Windows.Forms.MessageBoxButtons.OK,
               System.Windows.Forms.MessageBoxIcon.Warning);
            }
            finally
            {
                fs.Close();
            }
           
        }
        private void Write_Click(object sender, EventArgs e)
        {
            FileStream fs;
            try
            {
                fs = File.Create(fname.Text);
            }
            catch
            {
                MessageBox.Show("建立文件时出错。", "错误",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }

            byte[] content = new
                UTF8Encoding(true).GetBytes(this.content.Text);
            try
            {
                fs.Write(content, 0, content.Length);
                fs.Flush();
                MessageBox.Show("保存成功", "保存",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("写入文件时出错。", "错误", 
                    System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Warning);
            }
            finally
            {
                fs.Close();
            }
        }

        private void content_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
