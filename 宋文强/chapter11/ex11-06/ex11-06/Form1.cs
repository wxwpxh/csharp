using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//利用OleDbCommand对象的ExecuteReader()和ExecuteNonQuery()方法，设置不同的CommandText，对student.mdb中的“学生基本情况表”执行查看、添加、删除、修改等操作
namespace ex11_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=student.mdb";
        private void Form1_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
            conn.Open();
            cmd.Connection = conn;
        }
        private void menuBrowsing_Click(object sender, EventArgs e)//查看
        {
            richTextBox1.Text = "";
            cmd.CommandText = "Select * from 学生基本情况表";//选择表的所有字段
            OleDbDataReader result = cmd.ExecuteReader();	//获取数据集
            while (result.Read() == true)					//遍历整个数据集
            {
                for (int i = 0; i < result.FieldCount; i++)	//显示数据集当前行内容
                    richTextBox1.Text += result[i] + "  ";
                richTextBox1.Text += "\n";
            }
            result.Close();								//关闭数据集
        }

        private void menuInsert_Click(object sender, EventArgs e)//添加
        {
            cmd.CommandText = @"Insert Into 学生基本情况表 Values('2008338018','吕蒙','女',
'吉林','1990-8-23',608,'生物医学工程')";
            try
            {
                int val = cmd.ExecuteNonQuery();	//执行CommandText所要求的插入记录操作
                if (val > 0)
                    MessageBox.Show("已在表中成功插入指定记录!", "记录插入操作");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "记录插入失败"); }
        }
        private void menuEdit_Click(object sender, EventArgs e)//修改
        {
            cmd.CommandText = "Update 学生基本情况表 Set 高考成绩=624 Where 学号='2008338018'";
            int val = cmd.ExecuteNonQuery();	//执行CommandText所要求的修改记录操作
            if (val > 0)
                MessageBox.Show("表中指定记录修改成功!", "记录修改操作");
            else
                MessageBox.Show("未在表中找到要修改的记录!", "记录修改失败");
        }
        private void menuDelete_Click(object sender, EventArgs e)//删除
        {
            cmd.CommandText = "Delete From 学生基本情况表 Where 学号='2008338018'";
            int val = cmd.ExecuteNonQuery();		//执行CommandText所要求的删除记录操作
            if (val > 0)
                MessageBox.Show("已在表中成功删除指定记录!", "记录删除操作");
            else
                MessageBox.Show("表中未找到要删除的记录", "记录删除操作");
        }
    }
}
