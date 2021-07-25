using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseMonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "今天是：" + monthCalendar1.TodayDate.ToString();
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            monthCalendar1.BackColor = Color.Blue;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label3.Text = "起始日期：" + monthCalendar1.SelectionStart.ToString();
            label5.Text = "结束日期：" + monthCalendar1.SelectionEnd.ToString();
            label2.Text = "加3月日期：" + monthCalendar1.SelectionStart.AddMonths(3).ToString();
            label4.Text = "加3天日期：" + monthCalendar1.SelectionStart.AddDays(3).ToString();
            label6.Text = "加3年日期：" + monthCalendar1.SelectionStart.AddYears(3).ToString(); ;
        } 
       
    }
}
