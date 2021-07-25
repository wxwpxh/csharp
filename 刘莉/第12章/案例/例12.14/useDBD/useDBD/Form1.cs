using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace useDBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 对比度处理
        private void button1_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            Bitmap box1 = new Bitmap(pictureBox1.Image);
            Bitmap box2 = new Bitmap(pictureBox1.Image);
            int rr, x, m, lev, wid;
            int[] lut = new int[256];
            int[, ,] pic = new int[600, 600, 3];
            double dm;
            // 对比度改善的输入、输出灰度值对应关系
            lev = 80;
            wid = 100;
            for (x = 0; x < 256; x += 1)
            {
                lut[x] = 255;
            }
            for (x = lev; x < (lev + wid); x++)
            {
                dm = ((double)(x - lev) / (double)wid) * 255f;
                lut[x] = (int)dm;
            }
            for (int i = 0; i < pictureBox1.Image.Width - 1; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    c = box1.GetPixel(i, j);
                    pic[i, j, 0] = c.R;
                    pic[i, j, 1] = c.G;
                    pic[i, j, 2] = c.B;
                }
            }
            // 设置图像的对比度
            for (int i = 0; i < pictureBox1.Image.Width - 1; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    m = pic[i, j, 0];
                    rr = lut[m];
                    Color c1 = Color.FromArgb(rr, rr, rr);
                    box2.SetPixel(i, j, c1);
                }   
            }
            pictureBox2.Refresh();      // 刷新
            pictureBox2.Image = box2;   // 图片赋值到图片框中
        }
    }
}
