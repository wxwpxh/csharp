using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace useDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 查询字符串
        string selStr = @"select No, Name, XB, Grade, JG from JBQK";
        DBCon db=new DBCon ();  // 公共类DBCon.cs
        // Form1加载是填充“学号”列
        private void Form1_Load(object sender, EventArgs e)
        {
            db.dbcon();
            db.dbFill(selStr);
            // 将JBQK表的学号信息绑定到控件comboBox1
            comboBox1.ValueMember = "No";
            comboBox1.DataSource = db.dt.DefaultView;            
        }
        // 判断按照“学号”列或“姓名”列排序
        private void button1_Click(object sender, EventArgs e)
        {
            string selOrder = selStr;
            dataGridView1.Refresh();
            if (radioButton1.Checked)   // 按“学号”排序
            {
                selOrder = selStr + " order by No";
            }
            else                       // 按“姓名”排序
            {
                selOrder = selStr + " order by Name";
            }
            db.dbcon();
            db.dbFill(selOrder);
            dataGridView1.DataSource = db.dt;
        }
        // 数据表与绑定控件想关联
        private void button2_Click(object sender, EventArgs e)
        {
            db.dbcon();
            db.dbFill(selStr);
            dataGridView1.DataSource = db.dt;
        }
        // 将数据插入数据库
        private void button3_Click(object sender, EventArgs e)
        {
               db.dbcon();
                string insertInfo=
                "insert into JBQK(No, Name, XB, JG, Grade) values('"+comboBox1 .Text +"', '"+
                textBox1 .Text +"', '"+textBox2 .Text +"', '"+textBox3 .Text +"', '"+
                textBox4 .Text +"')";
                db.dbInsert(insertInfo);
        }
        // 通过组合框选择“学号”，并显示与之对应的记录
         private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selInfo = "select Name, XB, JG, Grade from JBQK where No= '" + comboBox1.Text.ToString().Trim () + "'";
            db.dbcon();
             db.dbSelect(selInfo);
             while (db.sdr.Read())
             {
                    textBox1.Text = db.sdr["Name"].ToString();
                    textBox2.Text = db.sdr["XB"].ToString();
                    textBox3.Text = db.sdr["JG"].ToString();
                    textBox4.Text = db.sdr["Grade"].ToString();
             }
        }
        // 修改数据
        private void button4_Click(object sender, EventArgs e)
        {
            db.dbcon();
            string strUpd = "update JBQK set Name='" + textBox1.Text.Trim() + "', XB='" + textBox2.Text.Trim() +
                "', JG='" + textBox3.Text.Trim() + "' where No='" + comboBox1.Text.Trim () + "'";
            db.dbUpdate(strUpd);
        }
        // 删除数据
        private void button5_Click(object sender, EventArgs e)
        {
            db.dbcon();
            string strUpd = "delete from JBQK where No='" + comboBox1.Text.Trim() + "'";
            db.dbDelete(strUpd);
        }
        // 通过更新绑定控件的内容，更改数据库
        private void button6_Click(object sender, EventArgs e)
        {
            db.dbcon();
            db.dbGridViewUpd();
        }
        // 退出应用程序
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
