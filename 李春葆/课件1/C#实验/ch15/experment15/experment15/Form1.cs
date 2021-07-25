using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; 

namespace experment15
{
    public partial class Form1 : Form
    {
        DataView mydv = new DataView();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string mystr;
            OleDbConnection myconn = new OleDbConnection();
            DataSet myds = new DataSet();
            DataSet myds1 = new DataSet();
            DataSet myds2 = new DataSet();
            DataSet myds3 = new DataSet();
            mystr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C#程序\ch15\school.accdb";
            myconn.ConnectionString = mystr;
            myconn.Open();
            OleDbDataAdapter myda = new OleDbDataAdapter("SELECT * FROM score", myconn);
            myda.Fill(myds, "score");
            mydv = myds.Tables["score"].DefaultView;
            //获得DataView对象mydv
            //以下设置ComboBox1的绑定数据
            OleDbDataAdapter myda1 = new OleDbDataAdapter("SELECT distinct 课程名 FROM score", myconn);
            myda1.Fill(myds1, "score");
            comboBox1.DataSource = myds1.Tables["score"];
            comboBox1.DisplayMember = "课程名";
            //以下设置DataGridView1的属性
            dataGridView1.DataSource = mydv;
            dataGridView1.GridColor = Color.RoyalBlue;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.CellBorderStyle =
                DataGridViewCellBorderStyle.Single;
            dataGridView1.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            myconn.Close();
            comboBox2.Items.Add("学号");
            comboBox2.Items.Add("课程名");
            comboBox2.Items.Add("分数");
            radioButton1.Checked = true; radioButton2.Checked = false;
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string condstr = "";
            //以下根据用户输入求得条件表达式condstr
            if (textBox1.Text != "")
                condstr = "学号 Like '" + textBox1.Text + "%'";
            if (comboBox1.Text != "")
                if (condstr != "")
                    condstr = condstr + " AND 课程名 = '" + comboBox1.Text + "'";
                else
                    condstr = "课程名 = '" + comboBox1.Text + "'";
            mydv.RowFilter = condstr;  //过滤DataView中的记录
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = ""; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string orderstr = "";
            //以下根据用户输入求得排序条件表达式orderstr
            if (comboBox2.Text != "")
                if (radioButton1.Checked)
                    orderstr = comboBox2.Text + " ASC";
                else
                    orderstr = comboBox2.Text + " DESC";
            mydv.Sort = orderstr;   //对DataView中记录排序
        }
    }
}
