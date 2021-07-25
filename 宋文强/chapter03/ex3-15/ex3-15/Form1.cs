using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 已知银行一年期整存整取的储蓄年利率为4.14%，在利率保持不变的情况下，经过多少年后，1000元存款能增值到2000元以上？
分析：在每年都将利息与本金一起继续存入的情况下，
1年后的存款总数为 1000×（1+0.0414）
2年后的存款总数为 1000×（1+0.0414）×（1+0.0414）
3年后的存款总数为 1000×（1+0.0414）×（1+0.0414）×（1+0.0414）
……
计算的规律就是每年的存款余额都在原来的基础上乘以（1+0.0414），但到底多少年以后才能达到使存款余额翻倍的目标，很难一下子估算出来。因此，这样的问题适合于使用while语句求解

 */
namespace ex3_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Click(object sender, EventArgs e)
        {
            double deposit = 1000;
            int i = 0;
            while (deposit <= 2000)				//若目标尚未达到，则继续执行循环
            {
                deposit *= 1.0414;				//每次执行该语句之后，都会更接近结束目标
                i++;
            }
            label1.Text = "经过" + i + "年后，存款总数达到" + deposit + "元";

        }
    }
}
