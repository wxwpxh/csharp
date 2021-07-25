using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace experment11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(System.Drawing.Color.Blue);
            Graphics gobj = this.CreateGraphics();
            gobj.DrawLine(myPen, 30, 30, 120, 120);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(System.Drawing.Color.Blue);
            Graphics gobj = this.CreateGraphics();
            gobj.DrawEllipse(myPen, new Rectangle(30, 30, 100, 100));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics gobj = this.CreateGraphics();
            string drawString = "使用DrawString方法";
            Font myFont = new Font("黑体", 16);
            Brush b = new SolidBrush(System.Drawing.Color.Blue);
            float x = 30.0F;
            float y = 30.0F;
            StringFormat myFormat = new StringFormat();
            gobj.DrawString(drawString, myFont, b, x, y, myFormat);
        }
    }
}
