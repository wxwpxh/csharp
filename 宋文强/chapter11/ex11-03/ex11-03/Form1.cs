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
namespace ex11_03
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
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = str;
            //OleDbConnection conn = new OleDbConnection(str);
            try
            {
                conn.Open();		    //打开数据库连接
                if (conn.State == ConnectionState.Open)
                    richTextBox1.Text = "数据库连接已经成功建立!";
            }
            catch (Exception ex)		//如果未能成功建立数据库连接，则捕获异常并报告错误信息
            {
                richTextBox1.Text = ex.Message.ToString();
            }
            finally
            {
                conn.Close();		//使用结束后关闭数据库连接
            }
        }
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
