using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//调用TranslateTransform()方法，在Timer控件的支持下，实现“折返跑步”的动画效果。
namespace ex10_23
{
    public partial class Form1 : Form
    {
        Graphics g;								//创建Graphics对象
        Bitmap bmpRight = new Bitmap("runRight.gif");	//向右“跑”的图片
        Bitmap bmpLeft = new Bitmap("runLeft.gif");		//向左“跑”的图片
        float dx;
        bool direction = true;						//平移的方向

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();			//Graphics对象实例化
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                        pictureBox1.Refresh();					//图片框刷新
            if (direction == false)					//向右平移的过程
            {
                if (dx < pictureBox1.Width - bmpRight.Width)	//如果未超过右边界
                {
                    g.TranslateTransform(5, 0);		//坐标系右移5像素
                    g.DrawImage(bmpRight, 0, 0);		//在新坐标原点绘出图片
                    dx += 5;						//记下当前绝对坐标
                }
                else
                    direction = true;					//更改平移方向为向左
            }
            else									//向左平移的过程
            {
                if (dx > 0)							//如果未超过左边界
                {
                    g.TranslateTransform(-5, 0);	//坐标系左移5像素
                    g.DrawImage(bmpLeft, 0, 0);		//从新坐标原点开始显示图像
                    dx -= 5;				//记下当前绝对坐标
                }
                else
                    direction = false;				//更改平移方向为向右
            }
        }

        
    }
}
