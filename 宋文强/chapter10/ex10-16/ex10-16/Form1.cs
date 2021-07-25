//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;
// 在窗体上以“上红下黄”、“左红右黄”两种渐变方式绘制文字，
namespace ex10_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;				  		//获取Graphics对象
            Font myfont = new Font("隶书", 40);			//定义字体对象
            Rectangle r1 = new Rectangle(0, 0, 350, 45);	//确定渐变填充的矩形区域
            LinearGradientBrush brush1 = new LinearGradientBrush(r1, Color.Red,Color.Yellow,LinearGradientMode.Vertical);
            g.DrawString("江山如此多娇", myfont, brush1, r1);
            Point p1 = new Point(0, 50);					//起始点坐标
            Point p2 = new Point(350, 95);					//终止点坐标
            LinearGradientBrush brush2 = new LinearGradientBrush(p1, p2, Color.Red, Color.Yellow);
            g.DrawString("江山如此多娇", myfont, brush2, p1);

        }
    }
}
