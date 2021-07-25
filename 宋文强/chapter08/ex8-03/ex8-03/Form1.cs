using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
//创建一个工具栏驱动，能实现最简单的文字编辑功能，并能在状态栏显示状态信息的记事本程序
namespace ex703
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string myfontFamily;
        int myfontSize;
        private void toolStripNew_Click(object sender, EventArgs e)
        {
            File.Create(@"d:\test\1.rtf");  //必须在程序的开头添加语句 using System.IO;
            toolStatus2.Text = "名为1.rtf的文件创建成功";
            //MessageBox.Show("名为1.rtf的文件创建成功", "创建文件");
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"d:\test\2.rtf", RichTextBoxStreamType.RichText);
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"d:\test\3.rtf");
            toolStatus2.Text = "名为3.rtf的文件保存成功";
            //MessageBox.Show("名为3.rtf的文件保存成功", "保存文件");
        }

        private void toolStripCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();					//将文本框中被选中的文字复制到剪贴板
        }

        private void toolStripPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();				//将剪贴板中的内容粘贴到文本框
        }

        private void toolStripUndo_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
                richTextBox1.Undo();
            else
                MessageBox.Show("不能撤消刚才的操作");
        }

        private void toolStripRedo_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo == true)
                richTextBox1.Redo();
            else
                MessageBox.Show("不能恢复刚才的操作");
        }
        
        private void toolStripFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            myfontFamily = toolStripFontFamily.Text;
            richTextBox1.SelectionFont = new Font(myfontFamily, myfontSize);
        }

        private void toolStripFontSize_TextUpdate(object sender, EventArgs e)
        {
            myfontSize = int.Parse(toolStripFontSize.Text);
            richTextBox1.SelectionFont = new Font(myfontFamily, myfontSize);
        }

        private void toolStripFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            myfontSize = int.Parse(toolStripFontSize.Text);
            richTextBox1.SelectionFont = new Font(myfontFamily, myfontSize);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myfontFamily = toolStripFontFamily.Text;
            myfontSize = int.Parse(toolStripFontSize.Text);
            toolStatus1.Text = "当前系统日期："+DateTime.Now.ToShortDateString();
        } 
    }
}
