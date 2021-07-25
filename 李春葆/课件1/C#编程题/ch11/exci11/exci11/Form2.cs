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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics gobj = this.CreateGraphics();
            gobj.FillPie(Brushes.Blue, 30, 30, 130, 80, 0, 300);
            gobj.FillPie(Brushes.Red, 30, 30, 130, 80, 0, -60);
        }
    }
}
