using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace picTranslate
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmpRight = new Bitmap("runRight.gif");
        Bitmap bmpLeft = new Bitmap("runLeft.gif");
        float dx;
        bool direction = true;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            if (direction == false)
            {
                if (dx < pictureBox1.Width-bmpRight.Width)
                {
                    g.TranslateTransform(5, 0);
                    g.DrawImage(bmpRight, 0, 0);
                    dx += 5;
                }
                else
                    direction = true;
            }
            else
            {
                if (dx > 0)
                {
                    g.TranslateTransform(-5, 0);
                    g.DrawImage(bmpLeft, 0, 0);
                    dx -= 5;
                }
                else
                    direction = false;
            }
        }
    }
}