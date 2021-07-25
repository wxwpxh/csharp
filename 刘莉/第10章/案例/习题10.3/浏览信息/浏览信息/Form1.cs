using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient ;

namespace 浏览信息
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString=@"Data Source=.;Initial Catalog=ScoreMIS;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            string sql = "SELECT  ID as 学号,name as 姓名,class as 班级 "+
                "FROM students";
            connection.Open();// 打开数据库连接
            SqlCommand command = new SqlCommand(sql,connection);
            SqlDataReader reader = command.ExecuteReader();
            string id,name,grade;
            int i = 1;
            while(reader.Read ())
            {
                id = reader["学号"].ToString ();
                name = reader["姓名"].ToString();
                grade = reader["班级"].ToString();
                listBox1.Items.Add("["+i.ToString() +"] ID="+id+
                    " name="+name+"class="+grade );
                i++;
            }
            connection.Close ();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
