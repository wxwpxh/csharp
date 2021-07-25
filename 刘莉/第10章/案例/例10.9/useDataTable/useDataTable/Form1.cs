using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace useDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 连接字符串
        string conStr = @"Data Source = .; Initial Catalog = TestDB; Integrated Security = True;";
        // 查询字符串
        string selStr = @"select No, Name, XB, Grade, JG from JBQK";
        SqlConnection sqlCon;           // SQL Server数据库的连接
        SqlDataAdapter sda;              // 数据适配器
        DataSet ds;                            // 数据集
        DataTable dt;                          // 内在中数据的一个表
        // 显示所有数据信息
        private void button1_Click(object sender, EventArgs e)
        {
            // 数据库的一个打开的连接
            sqlCon = new SqlConnection(conStr);
            sda = new SqlDataAdapter(selStr, conStr);
            ds=new DataSet ();
            // 填充数据集，实质是填充ds中的第0个表
            sda.Fill(ds, "JBQK");
            dt = ds.Tables ["JBQK"];
            // 将JBQK表的信息绑定到控件dataGridView1
            dataGridView1.DataSource = dt;
        }
        // 通过修改绑定控件的数据，更新数据库
        private void button2_Click(object sender, EventArgs e)
        {
            // 将DataSet所做的更改与关联的SQL Server数据库的更改相协调
            SqlCommandBuilder scb = new SqlCommandBuilder(sda );
            DialogResult result;        // 信息框的返回值
            result=MessageBox.Show("确定保存修改过的数据吗？",
                "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                dt = ds.Tables["JBQK"];
                sda.Update(dt);         // 更新数据库
                dt.AcceptChanges();     // 接受更新
            }
        }
        // 退出应用程序
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
