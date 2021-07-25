using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 例6._7
{
    public partial class Form1 : Form
    {
        private string temp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           

        }

      

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        
        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            temp = richTextBox1.SelectedText;//保存“复制”的文档内容
            粘贴ToolStripMenuItem.Enabled = true;
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            temp = richTextBox1.SelectedText;//保存被“剪切”的文档内容
            richTextBox1.SelectedText = "";
            粘贴ToolStripMenuItem.Enabled = true;
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            richTextBox1.SelectedText = temp;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {//剪切  --快捷菜单
            temp = richTextBox1.SelectedText;//保存被“剪切”的文档内容
            richTextBox1.SelectedText = "";
            粘贴ToolStripMenuItem.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {//复制  --快捷菜单
            temp = richTextBox1.SelectedText;//保存“复制”的文档内容
            粘贴ToolStripMenuItem.Enabled = true;
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {//粘贴  --快捷菜单
            richTextBox1.SelectedText = temp;
        }

        private void 磅ToolStripMenuItem_Click(object sender, EventArgs e)
        {//宋体，12磅
            richTextBox1.Font =new Font ("宋体",12);
        }

        private void 磅ToolStripMenuItem1_Click(object sender, EventArgs e)
        {//宋体，16磅
            richTextBox1.Font = new Font("宋体", 16);           
        }

        private void 加粗ToolStripMenuItem2_Click(object sender, EventArgs e)
        {//楷体，加粗
            richTextBox1.Font = new Font("楷体", 12, FontStyle.Bold);
        }

        private void 楷体ToolStripMenuItem1_Click(object sender, EventArgs e)
        {//楷体，下划线
            richTextBox1.Font = new Font("楷体", 12, FontStyle.Underline);
        }
        //自定义方法：设置各颜色菜单项为"未选定"状态
        private void FontColor()
        {
            //设置主菜单的各颜色菜单项为未选定状态
            红色ToolStripMenuItem.Checked = false;
            蓝色ToolStripMenuItem.Checked = false;
            绿色ToolStripMenuItem.Checked = false;
            默认颜色ToolStripMenuItem.Checked = false;
            //设置快捷菜单各菜单项为未被选中状态
            红色ToolStripMenuItem1.Checked = false;
            蓝色ToolStripMenuItem1.Checked = false;
            绿色ToolStripMenuItem1.Checked = false;
            默认颜色ToolStripMenuItem1.Checked = false;
        }
        private void 红色ToolStripMenuItem_Click(object sender, EventArgs e)
        {//主菜单：红色
            //设置文本框的字体颜色为红色
            richTextBox1.ForeColor = Color.Red;
            FontColor ();//调用自定义方法：设置各颜色菜单项为“未选定”状态
            红色ToolStripMenuItem.Checked = true;//主菜单项
            红色ToolStripMenuItem1.Checked = true;//快捷菜单项
            //设置状态栏的字体标签
            toolStripStatusLabel1.Text = "红色";
        }
        private void 红色ToolStripMenuItem1_Click(object sender, EventArgs e)
        {//快捷菜单，红色         
           红色ToolStripMenuItem_Click( sender,  e);
        }
        private void 绿色ToolStripMenuItem_Click(object sender, EventArgs e)
        {  //主菜单，绿色
            //设置文本框的字体颜色为绿色
            richTextBox1.ForeColor = Color.Green;
            FontColor();//设置各颜色菜单项为“未选定”状态
            //修改绿色菜单项为选定状态
            绿色ToolStripMenuItem.Checked = true;
            绿色ToolStripMenuItem1.Checked = true;
            //设置状态栏的字体标签
            toolStripStatusLabel1.Text = "绿色";
        }
        private void 绿色ToolStripMenuItem1_Click(object sender, EventArgs e)
        {   //快捷菜单，绿色
            绿色ToolStripMenuItem_Click( sender,  e);
        }
        private void 蓝色ToolStripMenuItem_Click(object sender, EventArgs e)
        {//主菜单：蓝色
            //设置文本框的字体颜色为蓝色
            richTextBox1.ForeColor = Color.Blue ;
            //设置各颜色菜单项为“未选定”状态
            FontColor();
            //修改蓝色菜单项为选定状态
            蓝色ToolStripMenuItem.Checked = true;
            蓝色ToolStripMenuItem1.Checked = true;           
            //设置状态栏的字体标签
            toolStripStatusLabel1.Text = "蓝色";
        }
        private void 蓝色ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //快捷菜单：蓝色
            蓝色ToolStripMenuItem_Click(sender, e);
        }
        private void 默认颜色ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //快捷菜单：默认颜色
            默认颜色ToolStripMenuItem_Click(sender, e);
        }
        private void 默认颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //主菜单：默认颜色            
            //设置文本框的字体颜色为默认颜色
            richTextBox1.ForeColor = Color.Black;
            //设置各颜色菜单项为“未选定”状态
            FontColor();
            //修改绿色菜单项为选定状态 
            默认颜色ToolStripMenuItem.Checked = true; //主菜单
            默认颜色ToolStripMenuItem1.Checked = true;//快捷菜单
            //设置状态栏的字体标签
            toolStripStatusLabel1.Text = "默认颜色";           
        }

       
    }
}
