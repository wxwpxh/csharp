using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//在窗体上显示图像文件，并添加说明性文字，然后把添加了文字的图像以另外的文件名保存。
namespace ex10_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Bitmap bmp = new Bitmap("basketball.jpg");      	//创建Bitmap对象
            Graphics pic = Graphics.FromImage(bmp);         	//从Bitmap对象创建Graphics对象
            Graphics gra = e.Graphics;                      	//获取Graphics对象
            gra.DrawImage(bmp, 0, 0);                        	//在窗体上显示图像
            Font myfont = new Font("楷体_GB2312", 20);			//定义在图像上写字的字体字号
            SolidBrush mybrush = new SolidBrush(Color.Red);	//定义在图像上写字的红色笔刷
            Point mypoint = new Point(10, 10);				//定义在图像上写字的起始位置
            gra.DrawString("篮球比赛", myfont, mybrush, mypoint); //在窗体上绘制文字
            pic.DrawString("篮球比赛", myfont, mybrush, mypoint); //在Bitmap对象上绘制文字
            bmp.Save("yaoming.jpg");                        	    //将Bitmap对象保存为图片文件

        }
    }
}
