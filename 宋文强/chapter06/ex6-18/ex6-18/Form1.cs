using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//利用String对象的ToCharArray()方法，将字符串切分成字符数组，然后利用伪随机数字序列逐个字符进行加密和解密，并在窗体上输出
/*
 说明：程序中声明了两个Random类的实例rnd1、rnd2，它们都使用了种子数20090516，因而用Next()方法产生的伪随机数字序列总是相同的。
 * 将字符串today切分成字符数组weather之后，依次将每个数组元素加上一个随机数，就实现了字符的加密；
 * 将加密的字符数组元素再依次减去相同的伪随机数序列，就实现了字符的解密
 */
namespace ex6_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            string today = "今天的天气实在是太好了";
            char[] weather = today.ToCharArray();	    //把字符串切分成字符数组
            Random rnd1 = new Random(20090516);        //产生具有固定种子数的伪随机数字序列
            for (int i = 0; i < weather.Length; i++)
            {
                weather[i] = (char)(weather[i] + rnd1.Next(1, 100));
                label1.Text += weather[i];
            }
            label1.Text += "\n";
            Random rnd2 = new Random(20090516);        //产生具有固定种子数的伪随机数字序列
            for (int i = 0; i < weather.Length; i++)
            {
                weather[i] = (char)(weather[i] - rnd2.Next(1, 100));
                label1.Text += weather[i];
            }

        }
    }
}
