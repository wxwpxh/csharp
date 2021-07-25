using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
创建Windows窗体应用程序，显示太阳系中水星、金星、地球以及火星的轨道周期（即绕太阳一圈的天数）*/
namespace ex2_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        enum planetPeriods : int		//声明枚举
        {
            Mercury = 88, Venus = 225, Earth = 365, Mars = 687
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text += "水星绕太阳一周的时间为" + (int)planetPeriods.Mercury + "天\n";
            label1.Text += "金星绕太阳一周的时间为" + (int)planetPeriods.Venus + "天\n";
            label1.Text += "地球绕太阳一周的时间为" + (int)planetPeriods.Earth + "天\n";
            label1.Text += "火星绕太阳一周的时间为" + (int)planetPeriods.Mars + "天\n";

        }

    }
}
