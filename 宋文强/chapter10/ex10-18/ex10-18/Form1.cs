using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//在图片框中的不同位置上多次单击鼠标，就按单击的顺序，依次连接相邻两次单击点之间画出一条直线，形成连续折线。
namespace ex10_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point p1, p2;
        Pen mypen = new Pen(Color.Black);
        bool start = false;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)		//鼠标左键按下，开始画线
            {
                if (start == false)				//首次鼠标按下，确定画线起点
                {
                    p1.X = e.X;					//保存画线起点
                    p1.Y = e.Y;
                    start = !start; 				//标记已开始画线
                }
                else
                {
                    p2.X = e.X;					//保存画线终点
                    p2.Y = e.Y;
                    Graphics g = pictureBox1.CreateGraphics();
                    g.DrawLine(mypen, p1, p2);		//在起点与终点之间画出一条直线
                    p1 = p2;					//将当前画线终点保存为下一次画线起点
                }
            }
            else								//鼠标右键按下，结束画线
                start = !start;					//标记结束画线

        }
    }
}
