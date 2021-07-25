using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex3_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char today = char.Parse(textBox1.Text);
            switch (today)
            {
                case '一':
                case '1': label2.Text = "Monday"; break;
                case '二':
                case '2': label2.Text = "Tuesday"; break;
                case '三':
                case '3': label2.Text = "Wednesday"; break;
                case '四':
                case '4': label2.Text = "Thursday"; break;
                case '五':
                case '5': label2.Text = "Friday"; break;
                case '六':
                case '6': label2.Text = "Saturday"; break;
                case '日':
                case '7': label2.Text = "Sunday"; break;
                default: label2.Text = "Not a valid number!"; break;
            }

        }
    }
}
