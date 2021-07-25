using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseTreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       

        private void button1_Click(object sender, EventArgs e)
        {//添加院系
            TreeNode newNode = new TreeNode(textBox1.Text, 0, 1);
            this.treeView1.Nodes.Add(newNode);
            this.treeView1.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {//添加班级
            TreeNode selectedNode = treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("必须先选定院系，才能添加班级");
                return; 
            }
            TreeNode subNode = new TreeNode(textBox2.Text, 2, 3);
            selectedNode.Nodes.Add(subNode);
            selectedNode.Expand();
            treeView1.Select();
        } 
        private void button3_Click(object sender, EventArgs e)
        {//删除节点
            TreeNode selectNode = treeView1.SelectedNode;
            if (selectNode == null)
            {
                MessageBox.Show("请选择你要删除的院系或班级");
                return;
            }
            TreeNode parentNode = selectNode.Parent;
            if (parentNode == null)
                treeView1.Nodes.Remove(selectNode);
            else
                parentNode.Nodes.Remove(selectNode);
            treeView1.Select();
        }

        private void button4_Click(object sender, EventArgs e)
        {//清空节点
            treeView1.Nodes.Clear();
        }   
        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            MessageBox.Show("修改成功！");
        }      
      
    }
}
