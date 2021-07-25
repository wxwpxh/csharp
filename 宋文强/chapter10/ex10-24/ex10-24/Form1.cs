using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//将图片以缓缓地向右展开、向下展开或向两边展开的形式显示在窗体上的图片框内。
namespace ex10_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        int iWidth, iHeight;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            iWidth = pictureBox1.Width;			//窗体大小改变时，获得图片框宽度
            iHeight = pictureBox1.Height;			//窗体大小改变时，获得图片框高度
        }
        private void menuOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();			//创建对话框对象
            openFile.Filter = "压缩图片文件(*.jpg)|*.jpg";			//设置图片类型过滤器
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(openFile.FileName);				//得到原尺寸的图像
                pictureBox1.Image = bmp;							//在图片框内显示图像
            }
        }

        private void menuRight_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(pictureBox1.BackColor);		//清除图片框中原内容，显示背景颜色
            for (int x = 0; x <= iWidth; x++)
                g.DrawImage(bmp, 0, 0, x, iHeight);
        }

        private void menuDown_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(pictureBox1.BackColor); 		//清除图片框中原有内容，显示背景颜色
            for (int y = 0; y <= iHeight; y++)
                g.DrawImage(bmp, 0, 0, iWidth, y);
        }

        private void menuDoorOpen_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(pictureBox1.BackColor); 		//清除图片框中原有内容，显示背景颜色
            for (int y = 0; y <= iWidth / 2; y++)
            {
                Rectangle dest = new Rectangle(iWidth / 2 - y, 0, y * 2, iHeight);
                Rectangle src = new Rectangle(0, 0, bmp.Width, bmp.Height);
                g.DrawImage(bmp, dest, src, GraphicsUnit.Pixel);
            }
        }
    }
}
