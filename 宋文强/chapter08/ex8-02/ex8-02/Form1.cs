using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//设计一个用来改变图片框背景颜色的上下文菜单。
namespace ex8_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuColorRed_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }

        private void menuColorGreenripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Green;
        }

        private void menuColorBlue_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Blue;
        }

        private void menuColorPurple_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Purple;
        }

        private void menuColorYellow_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Yellow;
        }

        private void menuColorWhite_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }

    }
}
