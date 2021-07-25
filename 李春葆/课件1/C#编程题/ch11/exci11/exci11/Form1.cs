using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exci11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gobj = this.CreateGraphics();
            Pen bluePen = new Pen(Color.Blue, 5);
            Pen redPen = new Pen(Color.Red, 5);
            Rectangle myRectangle = new Rectangle(50, 50, 100, 80);
            gobj.DrawRectangle(bluePen, 30, 20, 100, 80);
            gobj.DrawRectangle(redPen, myRectangle);
        }
    }
}
