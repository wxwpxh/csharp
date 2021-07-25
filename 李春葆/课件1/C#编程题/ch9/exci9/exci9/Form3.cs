using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exci9
{
    public partial class Form3 : Form
    {
        int a = 0, b = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("12");
            listBox1.Items.Add("10");
            listBox1.Items.Add("5");
            listBox1.Items.Add("8");
            listBox1.Items.Add("22");
            listBox1.Items.Add("25");
            listBox1.Items.Add("9");
            listBox2.Items.Add("9");
            listBox2.Items.Add("15");
            listBox2.Items.Add("20");
            listBox2.Items.Add("32");
            listBox2.Items.Add("18");
            listBox2.Items.Add("5");
            listBox2.Items.Add("7");
            listBox2.Items.Add("32");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = int.Parse(listBox1.Text);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            b = int.Parse(listBox2.Text);
            listBox3.Items.Add(string.Format("{0}×{1}={2}", a, b, a * b));
        }
    }
}
