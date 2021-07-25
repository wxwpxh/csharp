using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//利用GDI+提供的各种方法，实现窗体上图像的平移、旋转和缩放变换
namespace ex10_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Bitmap bmp = new Bitmap("plant.png");
            g.TranslateTransform(100, 100);         //坐标系第1次平移
            g.DrawString("第1次平移", this.Font, sbrush, -25, 0);
            float angle = 45;					//每次旋转的角度
            for (float i = 0; i < 360 / angle; i++)	//累计旋转360°
            {
                g.RotateTransform(angle); 		//坐标系旋转一个角度
                g.DrawImage(bmp, 0, 0);			//在旋转后的坐标系中绘制图像
                String str = (i.ToString());
                Font font = new Font("Times New Roman", 15, FontStyle.Regular);
                g.DrawString(str, font, sbrush, 20, 20);
            }
            g.TranslateTransform(200, 0);          //坐标系第2次平移，水平右移200
            g.DrawString("第2次平移", this.Font, sbrush, -25, 0);
            for (float i = 0; i < 360 / angle; i++)	//累计旋转360°
            {
                g.RotateTransform(angle); 		//坐标系旋转一个角度
                g.DrawImage(bmp, 0, 0); 			//在旋转后的坐标系中绘制图像
            }
            g.TranslateTransform(150, 0);           //坐标系第3次平移，水平右移150
            g.DrawString("第3次平移", this.Font, sbrush, -25, 0);
            g.ScaleTransform(0.6f, 0.6f);           //水平、垂直方向分别缩小到原来的60%
            for (float i = 0; i < 360 / angle; i++)	//累计旋转360°
            {
                g.RotateTransform(angle); 		//坐标系旋转一个角度
                g.DrawImage(bmp, 0, 0); 			//在旋转后的坐标系中绘制图像
            }

        }
    }
}
