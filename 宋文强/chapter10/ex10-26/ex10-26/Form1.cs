using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//打开选定的图像文件，显示到图片框内，并利用GetPixel()和SetPixel()方法将彩色图像转换成灰度图像。
namespace ex10_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();	//创建对话框对象
            openFile.Filter = "压缩图片文件(*.jpg)|*.jpg";	//设置图片类型过滤器
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(openFile.FileName);		//得到原尺寸的图像
                pictureBox1.Image = bmp;					//在图片框内显示彩色图像
            }

        }

        private void menuColorToGray_Click(object sender, EventArgs e)
        {
            //DateTime jobStart = DateTime.Now;             //任务开始时间

            //利用GetPixel()和SetPixel()方法

            Graphics g = Graphics.FromImage(bmp);		//从现有Bitmap对象创建Graphics对象
            for (int w = 0; w < bmp.Width; w++)		//利用双重循环遍历每一个像素
            {
                for (int h = 0; h < bmp.Height; h++)
                {
                    Color color = bmp.GetPixel(w, h);	//获取一个像素的颜色值
                    byte gray = (byte)((color.R * 229 + color.G * 587 + color.B * 114) / 1000);
                    bmp.SetPixel(w, h, Color.FromArgb(gray, gray, gray));//转换成灰度写回去
                }
            }
            g.DrawImage(bmp, 0, 0);
            pictureBox1.Image = bmp;		//在图片框中显示灰度图像
            g.Dispose();				//释放Graphics对象的资源

            
            //利用ColorMatrix

            //Graphics g = Graphics.FromImage(bmp);
            //Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            //ImageAttributes ia = new ImageAttributes();//创建ImageAttributes类的实例
            //float[][] colorMatrix = {   new float[] {0.299f, 0.299f, 0.299f, 0, 0},
            //                            new float[] {0.587f, 0.587f, 0.587f, 0, 0},
            //                            new float[] {0.114f, 0.114f, 0.114f, 0, 0},
            //                            new float[] {0,      0,      0,      1, 0},
            //                            new float[] {0,      0,      0,      0, 1}};
            //ColorMatrix cm = new ColorMatrix(colorMatrix);//创建ColorMatrix类的实例
            //ia.SetColorMatrix(cm, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            //g.DrawImage(bmp, rect, 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, ia);
            //pictureBox1.Image = bmp;
            //g.Dispose();

            //DateTime jobEnd = DateTime.Now;                   //任务结束时间
            //TimeSpan jobTime = jobEnd - jobStart;             //执行任务花费的时间
            //this.Text = jobTime.TotalMilliseconds.ToString();   //转换成毫秒
        }
    }
}
