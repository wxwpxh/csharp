using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//编写Windows窗体应用程序，计算并在窗体上输出100以内的所有素数
/*
 *说明：
这个程序的主体由一个嵌套的循环构成，其中外层循环用来控制把2到99的数依次进行检验，并将素数在窗体上输出；内层循环用来判断一个数i是否为素数。
对于有些数，例如87，按照定义，需要用2到9依次去除，才能确认它是否为素数，但是事实上只要用3除了之后，就已经知道它不是素数了，再继续计算下去没有任何意义，于是程序中将布尔类型变量b赋值为false，并且执行break语句退出内层循环。
在外层循环执行过程中，可以确认所有大于2的偶数都不是素数，于是执行continue语句，跳过循环体内的其它语句，执行下一次循环
*/
namespace ex3_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            for (int i = 2; i < 100; i++)
            {
                if (i > 2 && i % 2 == 0)		//确认当前的i不是素数，提前结束本次循环
                    continue;
                bool b = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        b = false;			//确认当前的i不是素数，做出标记
                        break;          		//确认当前的i不是素数，提前退出当前循环
                    }
                }
                if (b == true)
                    label1.Text += i + "\n";
            }

        }
    }
}
