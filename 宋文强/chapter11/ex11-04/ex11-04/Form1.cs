using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//使用OleDbConnection对象建立与Access数据库student.mdb的连接。如果连接成功，则在消息框中显示“数据库连接已经成功建立”，否则报告错误信息
namespace ex11_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=student.mdb";
            OleDbConnection conn = new OleDbConnection(str);  //创建数据库连接对象并初始化
            try
            {
                conn.Open();							//打开数据库连接
                if (conn.State == ConnectionState.Open)	//如果连接正常建立则执行统计操作
                {
                    OleDbCommand cmd = new OleDbCommand();	//创建Command对象
                    cmd.CommandText = "select count(*) from 学生基本情况表 where [性别]='男'";
                    cmd.Connection = conn;
                    //OleDbCommand cmd = new OleDbCommand("select * from 学生基本情况表", conn);
                    int mycount = (int)cmd.ExecuteScalar();	//返回统计结果，转换成所需要的数据类型
                    richTextBox1.Text = "男生的人数 = " + mycount.ToString();
                }
            }
            catch (Exception ex)						//捕获出错信息并以消息框的形式显示
            {
                richTextBox1.Text = ex.Message.ToString();
            }
            finally     							//使用结束后关闭数据库连接
            {
                conn.Close();
            }

        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
