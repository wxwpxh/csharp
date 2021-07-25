using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//在图片框pictureBox1中按下鼠标左键并拖动，画出任意曲线。释放鼠标左键则停止画线。
namespace ex10_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics gMouse;							//定义绘图表面
        Point ptStart, ptMove;						//定义画线的起点和终点坐标
        Pen pen1 = new Pen(Color.Black);				//定义画笔

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            gMouse = pictureBox1.CreateGraphics();		//确定绘图表面为对话框
            ptStart.X = e.X;						//保存画线的起点坐标
            ptStart.Y = e.Y;
            pictureBox1.Cursor = Cursors.Cross;		//光标变成十字形

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)			//若鼠标左键未按下，拖动鼠标不画线
            {
                ptMove.X = e.X;						//获取当前鼠标移动到的位置
                ptMove.Y = e.Y;
                gMouse.DrawLine(pen1, ptStart, ptMove);	//画出两点之间的一段直线
                ptStart = ptMove;					//把当前终点作为下一次的画线起点
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.Default;		//光标恢复正常形状
        }
    }
}
