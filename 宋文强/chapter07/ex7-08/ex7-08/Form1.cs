using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//利用单选按钮、复选框和GroupBox，对Label控件中文字的显示效果进行设置
namespace ex7_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float fontSize = label1.Font.Size;					//保留原来的字号
            FontStyle style = FontStyle.Regular;				//常规字形
            FontFamily family = label1.Font.FontFamily;
            if (radioButton1.Checked == true)					//字体设置
                family = new FontFamily("黑体");
            else if (radioButton2.Checked == true)
                family = new FontFamily("楷体_gb2312");
            else if (radioButton3.Checked == true)
                family = new FontFamily("宋体");
            if (radioButton4.Checked)						 	//颜色设置
                label1.ForeColor = Color.Red;
            else if (radioButton5.Checked)
                label1.ForeColor = Color.Green;
            else if (radioButton6.Checked)
                label1.ForeColor = Color.Blue;
            if (checkBox1.CheckState == CheckState.Checked)		//字形设置
                style |= FontStyle.Bold;
            if (checkBox2.CheckState == CheckState.Checked)
                style |= FontStyle.Italic;
            if (checkBox3.CheckState == CheckState.Checked)
                style |= FontStyle.Underline;
            label1.Font = new Font(family, fontSize, style);		//显示效果
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
