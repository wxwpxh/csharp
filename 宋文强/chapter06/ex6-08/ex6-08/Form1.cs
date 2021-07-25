using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//利用SetValue()方法为各数组元素赋以随机序列数值，利用GetValue()方法按顺序读取数组各元素的值，并在窗体上显示
/*
 程序中，SetValue()方法包含两个参数，第一个参数为向数组元素赋予的值，第二个参数为接收赋值的数组元素下标。
如果删除循环体中的第8、9行可执行代码，而把下面被“//”注释掉的第10、11行语句恢复为可执行状态，运行结果与图6-9完全相同。
对本例而言，从代码简洁和直观的角度来考虑，显然被注释掉的两个语句效果更好。但SetValue()和GetValue()方法在某些应用场合下更具有效率优势，本章后面还将有进一步的说明，请读者根据具体情况选择使用
*/
namespace ex6_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "数组各元素的值：\n\n";
            Random rnd = new Random();
            int[] a = new int[10];
            for (int i = a.GetLowerBound(0); i <= a.GetUpperBound(0); i++)
            {
                a.SetValue(rnd.Next(10, 99), i);		//向数组元素a[i]赋值
                label1.Text += a.GetValue(i) + "  ";	//把数组元素a[i]的值显示输出
                //a[i] = rnd.Next(10, 99);			//常规的数组元素赋值方法
                //label1.Text += a[i] + "  ";			//常规的数组元素引用方法
            }

        }
    }
}
