using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//从一组给定的2位正整数中找出最大值
/*
 分析：
把一组同类型的数据存储在数组中，执行此类运算最为便捷。程序中准备了一个变量max，准备用来存放最终找到的最大值。
查找开始时，把数组中首个元素的值赋给max，把它视为当前的最大值，然后逐次与数组中的第2个、第3个……直至最后一个元素进行比较。若发现第i个元素的值大于max，就用这个元素的值替代max，使之成为当前的最大值；当最后一个元素也完成比较之后，max中存储的就是最大值。
在本例的for循环语句中，利用Length属性获得数组中元素的总数，作为循环结束的控制条件，使程序具有了更大的灵活性。
*/
namespace ex6_05
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
            int max;							//准备用来存放最大值的变量
            int[] a = { 73, 69, 82, 51, 77, 19, 28, 92, 86 };
            max = a[0];                       		//把数组中首个元素的值赋给max
            for (int i = 1; i < a.Length; i++)		//一维数组长度由a.Length属性确定
            {
                label1.Text += a[i] + "  ";         //在同一行上输出数组的内容
                if (a[i] > max) max = a[i];         //如果a[i]>max，则用该元素的值替换max
            }
            label1.Text += "\n\n最大值= " + max;   //输出最大值

        }
    }
}
