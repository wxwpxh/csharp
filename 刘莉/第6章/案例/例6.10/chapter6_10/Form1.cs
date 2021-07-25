using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chapter6_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {//Form1中的“新建”菜单
            Form2 childForm = new Form2();
            childForm.Text = "新建文档.txt*";//文件名后面的*号表示该文件没有保存
            childForm.MdiParent = this;
            childForm.Show();//以非模式窗体的形式显示
        }
        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {//Form1中的“打开”菜单
            openFileDialog1.Filter = "文本文档(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Form2 childForm = new Form2(openFileDialog1 .FileName );
                childForm.MdiParent = this;
                childForm.Show();
            }
        }
        private void 水平布局ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //所有 MDI 子窗口均水平平铺在 MDI 父窗体的工作区内
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void 层叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 所有 MDI 子窗口均层叠在 MDI 父窗体的工作区内
            LayoutMdi(MdiLayout.Cascade);
        }
        private void 最小化所有窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //所有子窗体都最小化
            foreach (Form childForm in MdiChildren)
            {
                childForm.WindowState = FormWindowState.Minimized;
            }
        }
        private void 最大化所有窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //所有子窗体都最大化
            foreach (Form childForm in MdiChildren)
            {
                childForm.WindowState = FormWindowState.Maximized ;
            }
        }

       
    }
}
