using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 例6._2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            //窗体标题栏文本
            this.Text = "单击窗体";
            //设置窗体的位置
            this.Location = new Point(0,0);
            //设置窗体背景图像
            this.BackgroundImage = Image.FromFile(@"D:\C#程序设计\第六章\第六章案例\长城.jpg");
            //设置窗体的大小为背景图片的大小
            this.Size = new Size(1920,1200);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //窗体标题栏文本
            this.Text = "加载窗体";
            //设置窗体的背景为随机颜色
            Random ran = new Random();            
            this.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
        }
    }
}
