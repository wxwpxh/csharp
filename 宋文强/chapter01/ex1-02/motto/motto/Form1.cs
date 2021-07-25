using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
创建Windows窗体应用程序，这个程序的功能是：启动运行之后，屏幕上出现一个窗口。在“学习园地”的背景画面上，显示“学无止境”四个字，窗口底部显示着三个按钮。每单击一次标有“放大”字样的按钮，文字就会放大一点；每单击一次标有“缩小”字样的按钮，文字就会缩小一点；单击标有“结束”字样的按钮时，就会关闭窗口，结束程序运行
 */
namespace motto
{
    public partial class Form1 : Form
    {
        float myfontsize;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myfontsize = label1.Font.Size;
            label1.Left = (this.Width - label1.Width) / 2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, ++myfontsize);
            label1.Left = (this.Width - label1.Width) / 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, --myfontsize);
            label1.Left = (this.Width - label1.Width) / 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
