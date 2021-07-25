using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 例6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 窗体标题栏文本
            this.Text = "加载窗体";
            // 设置窗体的背景为随机颜色
            Random ran = new Random();
            this.BackColor = Color.FromArgb(ran.Next(0, 256),
        ran.Next(0, 256), ran.Next(0, 256));

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // 窗体标题栏文本
            this.Text = "单击窗体";
            // 设置窗体的位置
            this.Location = new Point(0, 0);
            // 设置窗体背景图像
            this.BackgroundImage = Image.FromFile(@"长城.jpg");
            // 设置窗体的大小为背景图片的大小
            this.BackgroundImageLayout = ImageLayout.Stretch;
          
        }
    }
}
