using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace 图像的显示与保存
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bit;
        // 显示图像
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "所有合适文件(*.bmp/*.jpg/*.gif)|" +
                "*.*|Bitmap文件(*.bmp)|*.bmp|Jpeg文件(*.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bit = new Bitmap (openFileDialog1 .FileName );
                pictureBox1.Image = bit;
            }
        }
        // 保存图像
        private void button2_Click(object sender, EventArgs e)
        {
            bit = new Bitmap(pictureBox1 .Image );
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
            string str = saveFileDialog1.FileName;
            bit.Save(str);
        }
        // 图像灰度化
        private void button3_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            //把图片框1中的图片给一个Bitmap类型
            Bitmap b = new Bitmap(pictureBox1.Image ) ;
            Bitmap b1 = bit;
            int rr, gg, bb, cc;
            for (int i = 0; i < bit.Width; i++)
            {
                for (int j = 0; j < bit.Height; j++)
                {
                    c = b.GetPixel(i, j);       // 获取指定像素的颜色
                    // 获取指定像素的R、G、B值
                    rr = c.R;
                    gg = c.G;
                    bb = c.B;
                    // 取得三基色R、G、B，求其和的平均值
                    cc = (int)((rr + gg + bb) / 3);
                    if (cc < 0) cc = 0;
                    if (cc > 255) cc = 255;
                    //用FromArgb把整型转换成颜色值  
                    Color c1 = Color.FromArgb(cc, cc, cc);
                    b1.SetPixel(i, j, c1);
                }
            }
            pictureBox2.Refresh();          // 刷新
            pictureBox2.Image = b1;        // 图片赋给图片框2 
        }
        //图像缩放
        private void button4_Click(object sender, EventArgs e)
        {
            Color color = new Color();
            //把图片框中的图片给一个Bitmap类型
            Bitmap box1 = new Bitmap(pictureBox1.Image);
            Bitmap box2 = new Bitmap(pictureBox1.Image);
            int r, g, b, size, k1, k2, xres, yres, i, j;
            xres = pictureBox1.Image.Width;     // 图像的原始宽度
            yres = pictureBox1.Image.Height;    // 图像的原始高度
            size = 8;
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
                            if (i + k1 < xres && j + k2 < yres)
                                box2.SetPixel(i + k1, j + k2, cc);  // 设置指定像素的颜色
                        }
                    }
                }
            }
            pictureBox2.Refresh();//刷新
            pictureBox2.Image = box2;//图片赋值到图片框中

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
