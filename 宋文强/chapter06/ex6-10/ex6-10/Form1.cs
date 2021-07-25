using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//利用Array.CreateInstance()方法创建一个拥有26个数组元素，下标最小编号为1的一维字符型数组，并从第一个元素开始依次存放大写英文字母
namespace ex6_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int[] length = new int[] { 26 };			//确定数组元素26个
            int[] lowbound = new int[] { 1 };			//确定下标最小值为1
            Array arr = Array.CreateInstance(typeof(char), length, lowbound);
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                arr.SetValue((char)(i + 64), i);			//用SetValue()方法向数组元素赋值
                label1.Text += arr.GetValue(i) + " ";	//用GetValue()方法获取数组元素值
            } 

        }
    }
}
