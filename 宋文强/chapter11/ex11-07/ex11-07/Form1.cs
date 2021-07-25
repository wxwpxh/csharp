using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//利用OleDbDataAdapter对象和DataGridView控件实现数据库内容的显示和交互式更新。
namespace ex11_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbDataAdapter adapter;			//在事件过程之前创建DataAdapter的实例
        DataTable table = new DataTable();	//创建DataTable的实例
        private void Form1_Load(object sender, EventArgs e)
        {
            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=student.mdb";
            string sql = "Select * From 学生基本情况表";
            adapter = new OleDbDataAdapter(sql, str);//DataAdapter对象构造函数重载形式之一
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.DeleteCommand = builder.GetDeleteCommand();		//自动生成属性
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
        }
        private void menuBrowsing_Click(object sender, EventArgs e)	//查看
        {
            table.Clear();
            adapter.Fill(table);		//把获得的数据集填充到table，然后断开与数据源的连接
            dataGridView1.DataSource = table;		//在dataGridView1中显示数据集的内容
        }
        private void menuSaving_Click(object sender, EventArgs e)		//保存
        {
        
            dataGridView1.EndEdit();	//在数据库更新期间禁止对dataGridView1的修改
            adapter.Update(table);	//把更新后的数据集保存到数据库
            MessageBox.Show("修改后的数据已经成功地保存到数据库中", "数据保存");

        }
    }
}

