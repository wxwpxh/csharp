using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//比较String类对象与StringBuilder类对象执行30000次字符串连接所花费的时间
/*
说明：
程序中引用了系统属性Environment.TickCount，用于获取自系统启动到当前时刻的毫秒数。在程序段开始执行前，将此属性赋予变量start，程序段执行结束后，再获取此属性赋予变量end，二者相减，即为该程序段执行所花费的时间
*/
namespace ex5_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            string str = "";
            StringBuilder strb = new StringBuilder();
            int times = 30000;					//准备执行字符串连接的次数
            int start, end;

            ///测试String类对象执行字符串连接所用的时间
            start = Environment.TickCount;		//获取从系统启动到当前时刻的毫秒数
            for (int i = 0; i < times; i++)
            {
                str += i.ToString();
            }
            end = Environment.TickCount;
            label1.Text = "string 对象花费时间 = " + (end - start).ToString() + "毫秒\n";

            ///测试StringBuilder类对象执行字符串连接所用的时间
            start = Environment.TickCount; 		//获取从系统启动到当前时刻的毫秒数
            for (int i = 0; i < times; i++)
            {
                strb.Append(i.ToString());
            }
            end = Environment.TickCount;
            label1.Text += "StringBuilder对象花费时间 = " + (end - start).ToString() + "毫秒\n";

        }
    }
}
