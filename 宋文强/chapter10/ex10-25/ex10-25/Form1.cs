using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//单击窗体，图片开始在窗体左上角显示，并逐渐放大，朝右下方伸展，直到与原图同样大小为止。
namespace ex10_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Rectangle rect = new Rectangle(0, 0, 0, 0);//绘图矩形区域的初始值均为0
        Bitmap bmp = new Bitmap("动物卡通.jpg");		//指定的图片文件与应用程序位于同一路径

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();	//创建以窗体为绘图表面的Graphics对象
            rect.Width += bmp.Width / 100;		//绘图矩形宽度扩大一个增量
            rect.Height += bmp.Height / 100;		//绘图矩形高度扩大一个保持宽高比的增量
            if (rect.Width > bmp.Width)			//若达到图像的原始宽度，则停止
                timer1.Enabled = false;
            else
                g.DrawImage(bmp, rect);			//在窗体上的绘图矩形内绘制图像
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;				//定时的时间间隔为50毫秒
            timer1.Enabled = true;				//单击窗体后，定时器开始起作用
        }
    }
}
