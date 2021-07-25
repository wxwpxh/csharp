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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
      
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public Form2(string filePath)
            : this()
        { //通过这种方式在两个窗体间直接传递数据
            richTextBox1.LoadFile(filePath, RichTextBoxStreamType.PlainText);
            this.Text = filePath;
        }
        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //设置过滤器字符串
            saveFileDialog1.Filter = "文本文件(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1 .FileName ,RichTextBoxStreamType.PlainText );
                this.Text = saveFileDialog1.FileName;
            }
        }
        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //将文本框中选中的内容复制到剪贴板
            richTextBox1.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             //用“剪贴板”的内容替换文本框中的当前选定内容
            richTextBox1.Paste();
        }
        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            另存为ToolStripMenuItem_Click(sender, e);
        }

    }
}
