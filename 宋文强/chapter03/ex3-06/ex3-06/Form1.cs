using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//在Windows窗体应用程序中，显示消息框中被选择的按钮返回值
namespace ex3_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否保存已修改过的内容？",
                                                  "保存文件",
                                                  MessageBoxButtons.YesNoCancel);
            label1.Text = "您刚才选择的按钮是：" + result;

        }
    }
}
