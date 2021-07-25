using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 例6._3
{
    public partial class Form2 : Form
    {
        //用来保存剪切和复制的文本内容
        private string temp = string.Empty;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //设置源文本框显示的内容
           textBox1 .Text  = "Windows 系统中处处是事件：鼠标按下、鼠标释放、键盘键按下……Windows的驱动方式是事件驱动，程序流程不由事件的顺序控制，而由事件的发生来控制。";
        }

        private void Font_Click(object sender, EventArgs e)
        {
            //设置字体为黑体，12磅，加粗，颜色为红色
            textBox2.Font = new Font("黑体", 12, FontStyle.Bold);
            textBox2.ForeColor = Color.Red;
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            //保存“复制”的文本内容
            this.temp = textBox1.SelectedText;  
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            //保存“剪切”的文本内容，并将选中的文本内容清空
            this.temp = textBox1.SelectedText;
            textBox1.SelectedText = "";
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            textBox2.Text = this.temp;
        }
    }
}
