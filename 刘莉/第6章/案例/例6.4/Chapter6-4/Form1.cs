using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chapter6_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 启动定时器
            timer1.Enabled = true;
            timer1.Interval = 300;
            // 初始化图片框距窗体左端和上端的值
            l = pictureBox1.Left;
            t = pictureBox1.Top;

        }

      

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //groupBox1.TabStop ;
        }
        int i = 1;// 当i=1时，图片框中显示BFLY1.bmp图片，否则显示BFLY2.bmp图片
        // 创建图片对象
        Bitmap b = null;
        // l, t用来记录图片框距窗体左端和上端的距离
        int l = 0;
        int t = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 1) i = 2;
            else i = 1;
            // 相对路径，前提：将图片放在/bin/debug目录下
            b = new Bitmap("BFLY" + i + ".BMP");
            pictureBox1.Image = b;
            // 通过左边和上边的值变化来产生移动的效果
            pictureBox1.Top = pictureBox1.Top - 5;
            pictureBox1.Left = pictureBox1.Left + 5;
            if (pictureBox1.Left > this.Width)
            {// 如果图片框飞出窗体，从原位置重新飞入
                pictureBox1.Left = l;
                pictureBox1.Top = t;
            }


        }
    }
}
