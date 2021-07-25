using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//在窗体上以中文标准格式显示当前日期与星期
namespace ex5_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            label1.Text = string.Format("今天是{0:D}", today);
            string[] Day = new string[] { "日", "一", "二", "三", "四", "五", "六" };
            label1.Text += string.Format(" 星期{0}", Day[Convert.ToInt16(today.DayOfWeek)]);

        }
    }
}
