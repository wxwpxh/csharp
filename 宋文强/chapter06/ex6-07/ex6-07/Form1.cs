using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//从一组随机产生的2位正整数中找出最小值
/*
 分析：
程序中运用Random类实例的Next()方法生成了一个随机数序列，并且声明了一个变量min，准备用来存放最终找到的最小值。
查找开始时，把数组中首个元素的值赋给min，把它视为当前的最小值，然后逐次与数组中的第2个、第3个……直至最后一个元素进行比较。若发现第i个元素的值小于min，就用这个元素的值替代min，使之成为当前的最小值；当最后一个元素也完成比较之后，min中存储的就是最小值
*/
namespace ex6_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "数组内容：";
            Random rnd = new Random();			//创建一个Random类的实例rnd
            int[] a = new int[10];				//创建具有10个元素的int型数组a
            int min, i;
            int lower = a.GetLowerBound(0);         //获取数组a第一维的下标最小值
            int upper = a.GetUpperBound(0);         //获取数组a第一维的下标最大值
            for (i = lower; i <= upper; i++)
            {
                a[i] = rnd.Next(10, 99); 			//把生成的随机数依次赋给数组a的各元素
                label1.Text += a[i] + "  ";		//在label1的同一行上显示各数组元素的值
            }
            min = a[lower];                         //把数组a中的首个元素值赋给min
            for (i = lower + 1; i <= upper; i++)	//在数组a中查找最小值并赋予min
                if (a[i] < min) min = a[i];
            label1.Text += "\n\n最小值 = " + min;

        }
    }
}
