using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace 修改信息
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = @"Data Source=.;Initial Catalog=Student;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(conStr);
            string updateStr = @"update stds set name ='"+textBox2.Text +
                "',grade='"+textBox3.Text +"' WHERE ID='"+textBox1 .Text +"'"; 
            sqlCon.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(updateStr, sqlCon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("数据'" + textBox1.Text + "','" +
                    textBox2.Text + "','" + textBox3.Text + "'修改成功！");
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
