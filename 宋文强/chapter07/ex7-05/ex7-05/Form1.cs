using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*调用Copy()方法，可以把文本框中被选择的文本复制到剪贴板；
 而调用Cut()方法，则是把文本框中被选择的文本移动到剪贴板，文本框中原先被选择的文本被删除；
 执行Paste()方法，则将剪贴板中的文字粘贴到文本框中。*/
namespace _7_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)  	//复制
        {
            textBox2.Text = textBox1.SelectedText;				//被选中的文本
            label2.Text += "(被选中的字符数为" + textBox1.SelectionLength + "个)";
        }
        private void button2_Click(object sender, EventArgs e)  	//删除
        {
            int textStart = textBox1.SelectionStart;			//被选中文字的开始位置
            int textLength = textBox1.SelectionLength;			//被选中文字的长度
            string string1 = textBox1.Text.Substring(0, textBox1.SelectionStart);
            string string2 = textBox1.Text.Substring(textLength + textStart);
            textBox2.Text = string1 + string2;
            label2.Text += "(剩余部分的文字长度为" + textBox2.Text.Length + ")";
        }
        private void button3_Click(object sender, EventArgs e)  	//结束
        {
            this.Close();
        }

    }
}
