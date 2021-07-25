using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient ;

namespace 数据库综合应用
{
    public partial class userInfo : Form
    {
        public userInfo()
        {
            InitializeComponent();
        }
        public userInfo(string str)
        {
            InitializeComponent();
            MessageBox.Show("欢迎您"+str+"，登录成功！");
        }
        public string conStr;
        SqlConnection sqlCon;
        //连接数据库
        public void DBConnect()
        {
            conStr = @"Data Source=.;Initial Catalog=ScoreMIS;Integrated Security=True";
            //新建SQL Server连接
            sqlCon = new SqlConnection(conStr);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect();
            string sql = "SELECT  *  FROM students";
            sqlCon.Open();// 打开数据库连接
            SqlCommand command = new SqlCommand(sql, sqlCon);
            SqlDataReader reader = command.ExecuteReader();
            string id, name, grade;
            listBox1.Items.Clear();
            int i = 1;
            while (reader.Read())
            {
                id = reader["ID"].ToString().Trim ();
                name = reader["name"].ToString().Trim ();
                grade = reader["class"].ToString().Trim ();
                listBox1.Items.Add("[" + i.ToString() + "] ID=" + id +
                    " name=" + name + " class=" + grade);
                i++;
            }
            sqlCon.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBConnect();
            string sql = "SELECT  ID  FROM students";
            sqlCon.Open();// 打开数据库连接
            SqlCommand command = new SqlCommand(sql, sqlCon);
            SqlDataReader reader = command.ExecuteReader();
            string id;
            while (reader.Read())
            {
                id = reader["ID"].ToString().Trim();
                comboBox1.Items.Add(id);
            }
            sqlCon.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBConnect();
            string updateStr = @"update students set name ='" + textBox1.Text.Trim () +
                "',class='" + textBox2.Text.Trim () + "' WHERE ID='" + comboBox1 .Text  + "'";
            sqlCon.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(updateStr, sqlCon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("数据'" + textBox1.Text.Trim () + "','" +
                    textBox2.Text.Trim () + "'修改成功！");
            }
            catch
            {
                MessageBox.Show("数据修改失败！");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnect();
            string sql = @"SELECT  name  FROM students where ID='"+
                comboBox1 .SelectedItem .ToString().Trim()+"'";
            sqlCon.Open();// 打开数据库连接
            SqlCommand command = new SqlCommand(sql, sqlCon);
            textBox1 .Text  = command.ExecuteScalar().ToString();
            sql = @"SELECT  class  FROM students where ID='" +
                comboBox1.SelectedItem.ToString().Trim() + "'";
            command = new SqlCommand(sql, sqlCon);
            textBox2 .Text  = command.ExecuteScalar().ToString();
            sqlCon.Close();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DBConnect();
            string deleteStr = @"delete from students where ID='" +
                comboBox1 .Text   + "'";
            sqlCon.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(deleteStr, sqlCon);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("数据'" + textBox1.Text + "'删除成功！");
                else
                    MessageBox.Show("数据'" + textBox1.Text + "'不存在！i=" + i.ToString());
            }
            catch
            {
                MessageBox.Show("数据删除失败！");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnect();
            comboBox1.Items.Add(comboBox1 .Text );
            string insertStr = @"insert into students(ID,name,class) values('" +
                comboBox1.Text + "','" + textBox1.Text + "','" +
                textBox2.Text + "')";
            sqlCon.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(insertStr, sqlCon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("数据'" + comboBox1.Text + "','" +
                    textBox1.Text + "','" + textBox2.Text + "'插入成功！");
            }
            catch
            {
                MessageBox.Show("数据插入失败！");
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
