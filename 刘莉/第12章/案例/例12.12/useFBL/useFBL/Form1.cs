using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace useFBL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 分辨率由256*256变换成64*64
        private void button1_Click(object sender, EventArgs e)
        {
            Color color = new Color();
            //把图片框中的图片给一个Bitmap类型
            Bitmap box1 = new Bitmap(pictureBox1.Image);
            Bitmap box2 = new Bitmap(pictureBox1.Image);
            int r, g, b, size, k1, k2, xres, yres, i, j;
            xres = pictureBox1.Image.Width;     // 图像的原始宽度
            yres = pictureBox1.Image.Height;    // 图像的原始高度
            size = 4;
            for (i = 0; i < xres - 1; i += size)
            {
                for (j = 0; j < yres - 1; j += size)
                {
                    color = box1.GetPixel(i, j);    // 获取指定像素的颜色
                    // 指定像素的颜色
                    r = color.R;
                    g = color.G;
                    b = color.B;
                    //用FromArgb把整型转换成颜色值
                    Color cc = Color.FromArgb(r, g, b);
                    for (k1 = 0; k1 <= size - 1; k1++)
                    {
                        for (k2 = 0; k2 <= size - 1; k2++)
                        {
                            if (i + k1 < xres && j+k2<yres  )
                                box2.SetPixel(i + k1, j + k2, cc);  // 设置指定像素的颜色
                        }
                    }
                }
            }
            pictureBox2.Refresh();          // 刷新
            pictureBox2.Image = box2;   // 图片赋值到图片框中
        }
    }
}
