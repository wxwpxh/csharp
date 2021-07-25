using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj11_1
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
            int x, y, w, h;
            x = 10; y = 10; w = 150; h = 100;
            gobj.DrawLine(Pens.Blue, x, y, x + w, y);
            gobj.DrawLine(Pens.Blue, x, y, x, y + h);
            gobj.DrawLine(Pens.Blue, x + w, y, x + w, y + h);
            gobj.DrawLine(Pens.Blue, x, y + h, x + w, y + h);
        }
    }
}
