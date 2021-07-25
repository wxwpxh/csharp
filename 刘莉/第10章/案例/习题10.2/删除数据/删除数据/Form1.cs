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

namespace 删除数据
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
            string deleteStr = @"delete from stds where ID='" +
                textBox1.Text + "'" ;
            sqlCon.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(deleteStr, sqlCon);
                int i=cmd.ExecuteNonQuery();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
