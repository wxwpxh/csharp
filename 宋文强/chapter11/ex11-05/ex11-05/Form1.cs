using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//查看student.mdb中“学生基本情况表”的内容及其字段结构，程序执行结果显示在RichTextBox中
namespace ex11_05
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
            conn.Open();								//打开数据库连接
            cmd.Connection = conn;
            cmd.CommandText = "Select * from 学生基本情况表";//获取指定表的所有字段
        }
        private void menuBrowsing1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            OleDbDataReader result = cmd.ExecuteReader();	//获取数据集
            Object[] dataRow = new Object[result.FieldCount];//定义长度满足要求的数组
            while (result.Read() == true)		//每调用一次Read()方法，指针后移一次
            {
                result.GetValues(dataRow);	//获取数据集当前行全部字段内容到数组dataRow
                for (int i = 0; i < result.FieldCount; i++)	//逐字段显示数据集当前行内容
                    richTextBox1.Text += dataRow[i] + "  ";
                richTextBox1.Text += "\n";
            }
            result.Close();								//关闭数据集
        }

        private void menuBrowsing2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            OleDbDataReader result = cmd.ExecuteReader();	//获取数据集
            while (result.Read() == true) 	//每调用一次Read()方法，指针后移一次
            {
                for (int i = 0; i < result.FieldCount; i++)	//显示数据集当前行内容
                    richTextBox1.Text += result[i] + "  ";
                richTextBox1.Text += "\n";
            }
            result.Close();								//关闭数据集
        }

        private void menuStructure_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "数据集结构如下：";
            OleDbDataReader result = cmd.ExecuteReader();	//获取数据集
            for (int i = 0; i < result.FieldCount; i++)		//显示各字段名及其数据类型
                richTextBox1.Text += result.GetName(i) + "\n";
            result.Close();								//关闭数据集
        }

    }
}
