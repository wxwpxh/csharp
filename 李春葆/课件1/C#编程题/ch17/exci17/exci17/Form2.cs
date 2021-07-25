using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exci17
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] scores = new int[] { 56, 97, 82, 92, 57, 81, 63, 60, 95, 48 };
            var scoreQuery =
                from score in scores
                where score >=60
                orderby score descending
                select score;
            textBox1.Text = "";
            foreach (int i in scoreQuery)
                textBox1.Text += i.ToString() + "\r\n";
        }
    }
}
