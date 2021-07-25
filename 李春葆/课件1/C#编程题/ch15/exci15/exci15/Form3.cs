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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string mystr;
            mystr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C#程序\ch15\school.accdb";
            OleDbConnection myconn = new OleDbConnection(mystr);
            OleDbDataAdapter myda = new OleDbDataAdapter("SELECT * FROM score", myconn);
            DataSet myds = new DataSet();
            BindingSource mybs = new BindingSource();
            myconn.Open();
            myda.Fill(myds, "score");
            mybs = new BindingSource(myds, "score");
            Binding mybinding1 = new Binding("Text", mybs, "学号");
            textBox1.DataBindings.Add(mybinding1);
            Binding mybinding2 = new Binding("Text", mybs, "课程名");
            textBox2.DataBindings.Add(mybinding2);
            Binding mybinding3 = new Binding("Text", mybs, "分数");
            textBox3.DataBindings.Add(mybinding3);
            bindingNavigator1.Dock = DockStyle.Bottom;
            bindingNavigator1.BindingSource = mybs;
            myconn.Close();

        }
    }
}
