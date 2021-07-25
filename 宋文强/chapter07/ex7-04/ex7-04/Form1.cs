using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//在程序运行期间，通过执行代码改变Label对象的属性
namespace _7_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "朝辞白帝彩云间\n千里江陵一日还\n";
            label1.Text += "两岸猿声啼不住\n轻舟已过万重山\n";
            label1.BackColor = Color.Transparent;		//背景颜色设置为透明
            label1.ForeColor = Color.Tomato;			//前景颜色设置为番茄色
            label1.Font = new Font("楷体_GB2312", 16, FontStyle.Bold | FontStyle.Underline);

        }

    }
}
