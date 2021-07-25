using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//比较模态窗体和非模态窗体。
namespace ex7_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)//打开模态窗体
        {
            Form modalForm = new Form();
            Size newsize = new Size(300, 150);
            modalForm.Size = newsize;
            modalForm.Text = "我是模态窗体";
            modalForm.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)//打开非模态窗体
        {
            Form nonmodalForm = new Form();
            Size newsize = new Size(300, 150);
            nonmodalForm.Size = newsize;
            nonmodalForm.Text = "我是非模态窗体";
            nonmodalForm.Show();
        }

    }
}
