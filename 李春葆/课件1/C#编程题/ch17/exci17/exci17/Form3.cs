﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] scores = new int[] { 56, 97, 82, 92, 57, 81, 63, 60, 95, 48 };
            var scoreQuery =
                (from score in scores
                 where score>=90
                select score).Count();
            textBox1.Text = "";
            textBox1.Text += scoreQuery.ToString() + "\r\n";
        }
    }
}
