using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//在一个字符串数组中查找与指定关键词匹配的元素，若找到则指出它的下标位置，若未找到则用-1表示其下标
namespace ex6_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "排序前：\n";
            string[] a = { "足球", "篮球", "排球", "乒乓球", "羽毛球", "网球" };
            for (int i = 0; i <= a.GetUpperBound(0); i++)
                label1.Text += a[i] + "  ";
            Array.Sort(a);								//对数组a进行排序
            label1.Text += "\n\n排序后：\n";
            for (int i = 0; i <= a.GetUpperBound(0); i++)
                label1.Text += a[i] + "  ";
            int x = Array.BinarySearch(a, "乒乓球");		//查找"乒乓球"在数组中的位置
            label1.Text += "\n\n乒乓球位于排序后第" + x + " 个单元的位置";
            int y = Array.BinarySearch(a, "保龄球");		//查找"保龄球"在数组中的位置
            label1.Text += "\n\n保龄球位于排序后第" + y + " 个单元的位置";

        }
    }
}
