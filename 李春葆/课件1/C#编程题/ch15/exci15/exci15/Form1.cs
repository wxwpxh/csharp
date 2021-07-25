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

namespace exci15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string　mystr,mysql;
            OleDbConnection myconn = new OleDbConnection();
            mystr=@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C#程序\ch15\school.accdb";
            myconn.ConnectionString = mystr;
            myconn.Open();
            OleDbCommand mycmd = new OleDbCommand();
            mysql = "SELECT student.学号,student.姓名,score.课程名,score.分数 FROM student,score WHERE student.学号=score.学号 ORDER BY student.学号";
            mycmd.CommandText = mysql;
            mycmd.Connection = myconn;
            OleDbDataReader myreader  = mycmd.ExecuteReader();
            listBox1.Items.Add("学号\t姓名\t\t课程名\t\t分数");
            listBox1.Items.Add("===========================================");    //循环读取信息
            while (myreader.Read())
                listBox1.Items.Add(String.Format("{0}\t{1}\t{2}\t{3}",myreader[0], myreader[1],myreader[2], myreader[3]));
            myconn.Close();
            myreader.Close();
        }
    }
}
