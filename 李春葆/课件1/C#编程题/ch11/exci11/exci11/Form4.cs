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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            int i;
            StringFormat strFormat;
            Font strFont;
            SolidBrush strBrush;
            Graphics gobj = this.CreateGraphics();
            for (i = 10; i <= 24; i += 6)
            {
                strFormat = new StringFormat();
                strFont = new System.Drawing.Font("隶书", i);
                strBrush = new SolidBrush(Color.Red);
                gobj.DrawString("中华人民共和国", strFont, strBrush, 2 * i, 3 * i, strFormat);
            }
        }
    }
}
