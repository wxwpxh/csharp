using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace useTextureBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;                     // 创建Graphics类  
        Bitmap bitmap;              // 创建Bitmap类
        Size size;                      // 图像大小
        string sizeStr = "";        // 输出字符串

        // 显示图像原始大小
        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            // 根据文件名创建原始大小的bitmap对象
            bitmap = new Bitmap(@"clock.jpg");
            g.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            size = bitmap.Size;     // 读取图像原始大小
            sizeStr = "原图像的大小为：" + size.ToString() + "；\n";
        }

        // 将其缩放到当前窗体大小
        private void button2_Click(object sender, EventArgs e)
        {  
            // 清除整个绘图画面，并以窗体背景色填充          
            g.Clear(this.BackColor);                   
            // 通过ClientRectangle.Size控件的工作区设置矩形大小
            bitmap = new Bitmap(bitmap, this.ClientRectangle.Size);
            TextureBrush myBrush = new TextureBrush(bitmap);
            g.FillEllipse(myBrush, this.ClientRectangle);
            size = bitmap.Size;
            sizeStr += "缩放后的图像大小为：" + size.ToString() + "。";
            MessageBox.Show(sizeStr );
        }
    }
}
