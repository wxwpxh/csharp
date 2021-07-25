using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chapter6_9
{
    public partial class frmLogo : Form
    {
        public frmLogo()
        {
            InitializeComponent();
        }
        private int s;
        private void timer1_Tick(object sender, EventArgs e)
        {
    //        int s=0;
            s=s+2;
            this .Opacity =(1000-s)/1000;//改变窗体的透明度
            if (this.Opacity == 0)
            {
                timer1.Stop();
                new frmEx().Show();
            }
        }
    }
}
