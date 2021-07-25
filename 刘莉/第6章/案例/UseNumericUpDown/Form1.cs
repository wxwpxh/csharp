using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseNumericUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             //设置当前系统日期中的年份
            year.Value = Convert.ToDecimal(DateTime.Now.Year);
            //设置当前系统日期中的月份
            month.Value = Convert.ToDecimal(DateTime.Now.Month);
             //设置当前系统日期中的日
            day.Value = Convert.ToDecimal(DateTime.Now.Day);
            //设置显示年份的区域为只读的
            year.ReadOnly = true;
            //设置显示月份的区域为只读的
            month.ReadOnly = true;
            //设置显示日的区域为只读的
            day.ReadOnly = true;      
          }

        private void year_ValueChanged(object sender, EventArgs e)
        {
            //实现控件的值改变时，显示当前最新的值
            label6.Text = year.Value + "年" + month.Value + "月" + day.Value + "日";
        }

        private void month_ValueChanged(object sender, EventArgs e)
        {
            //实现控件的值改变时，显示当前最新的值
            label6.Text = year.Value + "年" + month.Value + "月" + day.Value + "日";
        }

        private void day_ValueChanged(object sender, EventArgs e)
        {
            //实现控件的值改变时，显示当前最新的值
            label6.Text = year.Value + "年" + month.Value + "月" + day.Value + "日";
        }
    }
}
