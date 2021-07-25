using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//统计文本框中各英文字母出现的次数（不区分大小写），并显示在文本框下方的标签中。
/*
 分析：
(1)	为了分别统计并保存26个英文字母出现的次数，需要26个相应的存储单元，为此定义了一个具有26个元素的数组a。用a[0]存放字母A的出现次数，a[1]存放字母B的出现次数，依次类推。
(2)	将文本框内输入字符串中的字母全部转换成大写，然后利用Substring()方法逐一从中取出单个字符，继而将这个字符的Unicode值与大写字母A的Unidoce值相减，如果相减之差为0~25，则意味着这个字符是字母，便将其出现次数加1。
(3)	为了使统计结果能在标签中整齐地排列显示，输出时增加了检测条件，使每7个输出项目排列在一行，并且在每个输出项目后面添加适当数量的空格使之补齐。
*/
namespace ex6_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[26];						//定义数组a用来存放统计结果
            string s = textBox1.Text.ToUpper();			//把所有字母都转换成大写
            for (int i = 0; i < s.Length; i++)
            {
                int s1 = char.Parse(s.Substring(i, 1)) - 'A';//单个字符的Unicode值 - 'A'
                if (s1 >= 0 && s1 <= 25) a[s1]++;			//若是字母，保存到相应数组元素
            }
            for (int i = 0; i <= 25; i++)
            {
                if (i % 7 == 0) label1.Text += "\n";		//
                char c = Convert.ToChar('A' + i);
                label1.Text += c + "=" + a[i] + "    ";
            }

        }
    }
}
