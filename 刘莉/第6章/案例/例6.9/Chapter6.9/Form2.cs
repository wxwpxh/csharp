using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chapter6._9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = Form1.Count.ToString ();
            textBox2.Text = Form1.right.ToString ();
            textBox3.Text = ((Form1.right / (double) (Form1.Count) )* 100).ToString() + "%";
        }
    }
}
