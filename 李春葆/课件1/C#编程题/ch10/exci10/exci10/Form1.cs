using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exci10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menu11_Click(object sender, EventArgs e)
        {
            Font f = new Font("宋体", label1.Font.Size, label1.Font.Style);
            label1.Font = f;
        }

        private void menu12_Click(object sender, EventArgs e)
        {
            Font f = new Font("仿宋_GB2312", label1.Font.Size, label1.Font.Style);
            label1.Font = f;
        }

        private void menu13_Click(object sender, EventArgs e)
        {
            Font f = new Font("黑体", label1.Font.Size, label1.Font.Style);
            label1.Font = f;
        }

        private void menu14_Click(object sender, EventArgs e)
        {
            Font f = new Font("幼圆", label1.Font.Size, label1.Font.Style);
            label1.Font = f;
        }

        private void menu15_Click(object sender, EventArgs e)
        {
            Font f = new Font("楷体", label1.Font.Size, label1.Font.Style);
            label1.Font = f;
        }

        private void menu21_Click(object sender, EventArgs e)
        {
            Font f = new Font(label1.Font.Name, 28, label1.Font.Style);
            label1.Font = f;
        }

        private void menu22_Click(object sender, EventArgs e)
        {
            Font f = new Font(label1.Font.Name, 20, label1.Font.Style);
            label1.Font = f;
        }

        private void menu23_Click(object sender, EventArgs e)
        {
            Font f = new Font(label1.Font.Name, 16, label1.Font.Style);
            label1.Font = f;
        }

        private void menu24_Click(object sender, EventArgs e)
        {
            Font f = new Font(label1.Font.Name, 12, label1.Font.Style);
            label1.Font = f;
        }

        private void menu25_Click(object sender, EventArgs e)
        {
            Font f = new Font(label1.Font.Name, 8, label1.Font.Style);
            label1.Font = f;
        }
    }
}
