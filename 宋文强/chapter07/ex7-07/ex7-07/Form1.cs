using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//利用RichTextBox控件创建一个非常简单的文档编辑程序
namespace ex7_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {           //打开指定路径下的RTF格式文件
            richTextBox1.LoadFile(@"F:\myBook\cx.txt", RichTextBoxStreamType.PlainText);
        }
        private void button2_Click(object sender, EventArgs e)
        {           //设置被选中的文章标题格式（必须先选中标题文字，然后才能单击命令按钮）
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;		//水平居中
            richTextBox1.SelectionColor = Color.Red;						//设置标题为红色
            richTextBox1.SelectionFont = new Font("隶书", 24, FontStyle.Bold);	//设置字体和字形
        }
        private void button3_Click(object sender, EventArgs e)
        {           //用英文“Disney”替换被选中的“迪斯尼"（必须先选中文字块，然后才能单击按钮）
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            string str1 = richTextBox1.SelectedText;
            richTextBox1.SelectedText = str1.Replace("迪斯尼", "Disney");
        }
        private void button4_Click(object sender, EventArgs e)
        {           //撤消刚才的操作
            if (richTextBox1.CanUndo == true)
                richTextBox1.Undo();
            else
                MessageBox.Show("无法撤消");
        }
        private void button5_Click(object sender, EventArgs e)
        {           //恢复刚才撤消的操作
            if (richTextBox1.CanRedo == true)
                richTextBox1.Redo();
            else
                MessageBox.Show("无法恢复");
        }
        private void button6_Click(object sender, EventArgs e)
        {           //将文件以RTF格式保存到指定路径下
            richTextBox1.SaveFile(@"F:\myBook\cx.txt", RichTextBoxStreamType.PlainText);
            DialogResult result;
            result = MessageBox.Show("文件保存已经完成，是否关闭？", "保存文件",
    MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) this.Close();
        }

    }
}
