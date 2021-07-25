using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//调用DrawLine()方法在窗体上画出几条不同样式的直线。
namespace ex10_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;                //获取Graphics对象
            Pen pen1 = new Pen(Color.Black);        //创建宽度为的黑色画笔
            Bitmap bmp = new Bitmap("leaf.gif");
            TextureBrush tb = new TextureBrush(bmp);//创建纹理笔刷
            Pen pen2 = new Pen(tb, 16);              //创建以纹理笔刷为笔尖的异型画笔
            g.DrawLine(pen1, 20, 24, 250, 24);      //画出一条直线
            pen1.DashStyle = DashStyle.Dash;        //选择短划虚线样式
            g.DrawLine(pen1, 20, 48, 250, 48);      //画出一条虚线
            g.DrawLine(pen2, 20, 80, 250, 80);      //画出一条用小图片组成的直线
        }
    }
}
