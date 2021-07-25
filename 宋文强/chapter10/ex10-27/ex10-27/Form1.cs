using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//利用彩虹编码基准颜色条，实现灰度图像到伪彩色图像的转换。
namespace ex10_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        Bitmap refbmp = new Bitmap("基准颜色.jpg");     	  //获得基准颜色编码表

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();	   //声明打开文件对话框控件
            if (dialog.ShowDialog() == DialogResult.OK)		   //获得文件名
            {
                bmp = new Bitmap(dialog.FileName);			   //将灰度图片作为处理对象
                pictureBox1.Image = bmp;					   //显示灰度图片
            }
        }

        private void menuPseudo_Click(object sender, EventArgs e)
        {
            waiting();                                          //显示请求等待的信息
            Color[] refColor = new Color[256];				   //用来存储颜色编码表的数组
            for (int x = 5; x < 260; x++)					   //丢弃头、尾各5个像素
                refColor[x - 5] = refbmp.GetPixel(x, 15);       //取基准颜色图像的中间部分
            Bitmap pseudo = new Bitmap(bmp.Width, bmp.Height);  //存储伪彩色图像
            for (int x = 0; x < pseudo.Width; x++)              //逐个像素进行伪彩色转换
                for (int y = 0; y < pseudo.Height; y++)
                    pseudo.SetPixel(x, y, refColor[bmp.GetPixel(x, y).G]);
            pictureBox1.Image = pseudo;                         //显示伪彩色图像

        }

        private void waiting()							   //显示请求等待的信息
        {
            Graphics g = pictureBox1.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.White);
            Font font = new Font("宋体", 20);
            Point point = new Point(10, 10);
            g.DrawString("正在转换，请稍等……", font, sb, point);
        }
    }
}
