using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.OleDb; 

namespace experment16
{
    public partial class Form1 : Form
    {
        XmlDocument myxmldoc = new XmlDocument();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string mystr, mysql, mysql1;
            OleDbConnection myconn = new OleDbConnection();
            mystr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C#程序\ch15\school.accdb";
            myconn.ConnectionString = mystr;
            myconn.Open();
            mysql = "SELECT student.学号, student.姓名, score.课程名," +
                " score.分数 FROM student,score " +
                "WHERE student.学号 = score.学号 " +
                "ORDER BY student.学号";
            OleDbDataAdapter myda = new OleDbDataAdapter(mysql, myconn);
            DataSet myds = new DataSet();
            myda.Fill(myds);
            mysql1 = "SELECT student.学号, AVG(score.分数) AS 平均分 " +
                "FROM student,score WHERE  student.学号 = score.学号 " +
                "GROUP BY student.学号";
            OleDbDataAdapter myda1 = new OleDbDataAdapter(mysql1, myconn);
            myda1.Fill(myds);
            myds.WriteXml(@"D:\C#实验\ch16\stud1.xml");
            myconn.Close();
            myxmldoc.Load(@"D:\C#实验\ch16\stud1.xml");
            XmlNodeList mynodes = myxmldoc.SelectNodes("NewDataSet/Table/学号");
            foreach (XmlNode item in mynodes) //将不重复的学号添加到组合框中
                if (!comboBox1.Items.Contains(item.InnerText))
                    comboBox1.Items.Add(item.InnerText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                string xpath = "NewDataSet/Table[学号='" + comboBox1.Text + "']";
                XmlNodeList mynodes = myxmldoc.SelectNodes(xpath);
                textBox1.Text = "";
                foreach (XmlNode item in mynodes)
                {
                    XmlNodeList studnodes = item.ChildNodes;
                    foreach (XmlNode sitem in studnodes)
                        textBox1.Text = textBox1.Text + sitem.Name + ":" + sitem.InnerText + "\t";
                    textBox1.Text = textBox1.Text + "\r\n";
                }
            }
            else
                MessageBox.Show("必须选择一个学生学号"); 
        }
    }
}
