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
    public partial class Form2 : Form
    {
        BindingSource mybs = new BindingSource();　//类字段
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string mystr, mysql;
            OleDbConnection myconn = new OleDbConnection();
            DataSet myds = new DataSet();
            mystr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C#程序\ch15\school.accdb";
            myconn.ConnectionString = mystr;
            myconn.Open();
            mysql = "SELECT * FROM score";
            OleDbDataAdapter myda = new OleDbDataAdapter(mysql, myconn);
            myda.Fill(myds, "score");
            mybs = new BindingSource(myds, "score");
            Binding mybinding1 = new Binding("Text", mybs, "学号");
            textBox1.DataBindings.Add(mybinding1);
            //将student.学号与textBox1文本框绑定起来
            Binding mybinding2 = new Binding("Text", mybs, "课程名");
            textBox2.DataBindings.Add(mybinding2);
            Binding mybinding3 = new Binding("Text", mybs, "分数");
            textBox3.DataBindings.Add(mybinding3);
            myconn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mybs.Position != 0)
                mybs.MoveFirst();  //移到第一个记录
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mybs.Position != 0)
                mybs.MovePrevious();　//移到上一个记录
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mybs.Position != mybs.Count - 1)
                mybs.MoveNext();　//移到下一个记录
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mybs.Position != mybs.Count - 1)
                mybs.MoveLast();　//移到最后一个记录
        }
    }
}
