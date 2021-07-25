using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//用进度条指示程序执行进度情况
namespace ex7_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 1000;						//进度条填满时的对应值
            progressBar1.Minimum = 0;							//进度条空白时的对应值
        }
        private void button1_Click(object sender, EventArgs e)	//开始
        {
            label2.Text = "";
            for (int i = 0; i < progressBar1.Maximum; i++)
                for (long j = 0; j < 300000; j++)
                    progressBar1.Value = i;
            label2.Text = "程序执行结束！";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
