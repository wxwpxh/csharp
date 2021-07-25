using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*用单色、图案、线性渐变、路径渐变和纹理笔刷填充窗体工作区上的椭圆形区域，如图10-5所示。
程序中使用MenuStrip控件创建了一个菜单，为5种笔刷分别书写了代码，但只显示了线性渐变和纹理两种笔刷填充的结果。*/
namespace ex10_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();		//定义窗体为绘图表面
            rect = this.ClientRectangle;		//将整个窗体工作区定义为Rectangle对象
        }
        Graphics g;						//创建各事件过程公用的Graphics对象
        Rectangle rect;						//创建各事件过程公用的Rectangle对象

        private void brushSolid_Click(object sender, EventArgs e)
        {
            SolidBrush solid = new SolidBrush(Color.GreenYellow);
            g.FillEllipse(solid, rect);
        }

        private void brushHatch_Click(object sender, EventArgs e)
        {
            HatchBrush hatch = new HatchBrush(HatchStyle.Cross, Color.White);
            g.FillEllipse(hatch, rect);
        }

        private void brushLinearGradient_Click(object sender, EventArgs e)
        {
            LinearGradientBrush linear = new LinearGradientBrush(rect, Color.IndianRed,Color.WhiteSmoke, LinearGradientMode.Horizontal);
            g.FillEllipse(linear, rect);
        }

        private void brushPathGradient_Click(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(rect);								//把椭圆形添加到路径中
            PathGradientBrush pathbrush = new PathGradientBrush(gp);
            pathbrush.CenterColor = Color.White;					//区域中心颜色
            pathbrush.SurroundColors = new Color[] { Color.Thistle };	//区域边缘颜色
            g.FillPath(pathbrush, gp); 
        }

        private void brushTexture_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("leaf.gif");
            TextureBrush texture = new TextureBrush(bmp);			//用小图片作为纹理
            g.FillEllipse(texture, rect);							//用小图片填充椭圆
        }
    }
}
