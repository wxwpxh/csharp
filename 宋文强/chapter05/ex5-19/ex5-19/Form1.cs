using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//在窗体上显示用2位随机整数构成的7×7矩阵
namespace ex5_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                    label1.Text += rnd.Next(10, 100) + "  ";
                label1.Text += "\n";
            }

        }
    }
}
