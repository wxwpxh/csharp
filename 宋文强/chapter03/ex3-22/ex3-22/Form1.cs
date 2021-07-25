using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * 这是一个我国古代的著名算术题目：同一笼中有鸡和兔共36只，已知它们有100只脚，问鸡和兔各有多少只？
分析：运用二元一次方程，可以很快地求解这个问题。但对于本例来说，由于计算的次数不多，不妨采用穷举法，通过有限次数的试探得到答案。
*/
namespace ex3_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int rabbit, chick,feet;
            for (chick = 1; chick <= 36; chick++)
            {
                feet = chick * 2 + (36 - chick) * 4;
                if (feet == 100)
                    break;
            }
            rabbit = 36 - chick;
            label1.Text = "鸡有" + chick + "只\n";
            label1.Text += "兔有" + rabbit + "只";
        }
    }
}
