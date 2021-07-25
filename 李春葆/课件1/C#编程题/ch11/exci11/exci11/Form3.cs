using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace exci11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Graphics gobj = this.CreateGraphics();
            HatchBrush myBrush = new HatchBrush(HatchStyle.BackwardDiagonal, Color.Blue, Color.Green);
            Pen myPen = new Pen(Color.Red, 8);
            gobj.DrawEllipse(myPen, 20, 20, 150, 100);
            gobj.FillEllipse(myBrush, 20, 20, 150, 100);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
