using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*在窗体上添加两个PictureBox控件，单击“打开图片”按钮，通过对话框选择图片文件并显示在左边图片框PictureBox1中；
 在PictureBox1中按下鼠标并拖动，绘出一个灰色的矩形区域，释放鼠标时，
 灰色区域所覆盖的图像被复制显示到右边图片框PictureBox2中。*/
namespace ex10_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Rectangle rect = new Rectangle(0, 0, 0, 0);
        Point p1 = new Point(0, 0);

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "图片(*.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bm = new Bitmap(openFileDialog1.FileName.ToString());
                if (bm.Width == 320 && bm.Height == 240)
                    pictureBox1.Image = bm;
                else
                    MessageBox.Show("请选择大小为320*240的图片");
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            rect.X = e.X;
            rect.Y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.X < rect.X)
                    p1.X = e.X;
                else
                    p1.X = rect.X;
                if (e.Y < rect.Y)
                    p1.Y = e.Y;
                else
                    p1.Y = rect.Y;
                panel1.Left = pictureBox1.Left + p1.X;
                panel1.Top = pictureBox1.Top + p1.Y;
                panel1.Width = Math.Abs(e.X - rect.X);
                panel1.Height = Math.Abs(e.Y - rect.Y);
                panel1.Visible = true;
            }
            else
                panel1.Visible = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                rect.X = p1.X;
                rect.Y = p1.Y;
                rect.Width = panel1.Width;
                rect.Height = panel1.Height;
                Bitmap bm = new Bitmap(pictureBox1.Image);
                Bitmap bmTmp = new Bitmap(rect.Width, rect.Height);
                bmTmp = bm.Clone(rect, bm.PixelFormat);
                pictureBox2.Image = bmTmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
