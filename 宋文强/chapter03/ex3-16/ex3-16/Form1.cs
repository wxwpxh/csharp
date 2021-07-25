using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 若全世界人口的年平均增长率保持在0.8%，计算全世界人口从50亿增加到60亿需要多少年？
这个问题可以用以下表达式描述：
    60 = 50 *（1+0.008）n
分析：此问题可以利用对数直接求解，得到n的值。在这里，我们采用试探法，逐次增加年数，利用循环求解。对于这种有预定达到的计算目标，但事先无法知道循环次数的求解问题，最好使用do语句构成循环结构。

 */
namespace ex3_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            double human = 50, year = 0;
            do
            {
                human *= 1.008;
                year++;
            }
            while (human < 60);
            label1.Text = "经过" + year + "年后，世界人口达到" + human + "亿";

        }
    }
}
