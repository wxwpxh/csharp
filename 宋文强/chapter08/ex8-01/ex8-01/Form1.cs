using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
/*创建一个菜单驱动，能实现最简单文字编辑功能的记事本程序，二级菜单中的每个选项均可视为一个按钮控件。*/
namespace ex701
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuFileNew_Click(object sender, EventArgs e)//创建文件
        {
            File.Create(@"d:\test\1.rtf");  //必须在程序的开头添加语句 using System.IO;
            MessageBox.Show("名为1.rtf的文件创建成功","创建文件");
        }

        private void menuFileOpen_Click(object sender, EventArgs e)//打开文件
        {
            richTextBox1.LoadFile(@"d:\test\2.rtf", RichTextBoxStreamType.RichText);
        }

        private void menuFileSave_Click(object sender, EventArgs e)//保存文件
        {
            richTextBox1.SaveFile(@"d:\test\3.rtf");
            MessageBox.Show("名为3.rtf的文件保存成功", "保存文件");
        }

        private void menuFileExit_Click(object sender, EventArgs e)//退出运行
        {
            this.Close();   //结束程序，退出运行
        }

        private void menuHelpAbout_Click(object sender, EventArgs e)//关于作者
        {
            MessageBox.Show("我是重庆大学教务处赵品勇，欢迎与我联系","作者自我介绍");
        }

        private void menuEditUndo_Click(object sender, EventArgs e)//撤消
        {
            if (richTextBox1.CanUndo == true)
                richTextBox1.Undo();
            else
                MessageBox.Show("不能撤消刚才的操作");
        }

        private void menuFormatFont_Click(object sender, EventArgs e)//字体
        {
            richTextBox1.SelectionFont = new Font("隶书", 24, FontStyle.Bold);//设置字体
        }

        private void menuFormatColor_Click(object sender, EventArgs e)//颜色
        {
            richTextBox1.SelectionColor = Color.Red;    //设置被选中文字为红色
        }

        private void menuEditReplace_Click(object sender, EventArgs e)//替换
        {
            string str1 = richTextBox1.SelectedText;
            richTextBox1.SelectedText = str1.Replace("迪斯尼", "Disney");
        }

        private void menuEditCut_Click(object sender, EventArgs e)//剪切
        {
            richTextBox1.Cut();
        }

        private void menuEditCopy_Click(object sender, EventArgs e)//复制
        {
            richTextBox1.Copy();
        }

        private void menuEditPaste_Click(object sender, EventArgs e)//粘贴
        {
            richTextBox1.Paste();
        }

        private void menuEditFind_Click(object sender, EventArgs e)//查找
        {
            int position = richTextBox1.Text.IndexOf("迪斯尼");
            if (position >= 0)
                richTextBox1.Select(position, 3);
        }
    }
}
