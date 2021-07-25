using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace experment13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                label2.Text = "子文件夹个数为:" + dirs.Length;
            }
            catch (Exception ex)
            {
                label2.Text = "不存在指定的文件夹!";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
        }
    }
}
