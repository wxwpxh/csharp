using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//在图片框中两个不同的位置上单击鼠标，在两点间画出一条直线
namespace ex10_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point p1, p2;							//定义画线起点和终点坐标
        Pen mypen = new Pen(Color.Black);			//定义画笔
        bool start = false;						//判断是否已开始画线的标记

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (start == false)					//第一次按下鼠标左键
            {
                p1.X = e.X;						//保存画线起点
                p1.Y = e.Y;
                start = !start;					//标记已开始画线
            }
            else
            {
                p2.X = e.X;						//保存画线终点
                p2.Y = e.Y;
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawLine(mypen, p1, p2);		//在起点与终点之间画出一条直线
                start = !start;					//标记结束画线
            }

        }
    }
}
