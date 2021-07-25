using System;
using System.Text;
using System.Windows.Forms;

namespace ex4_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person student1 = new Person();
            student1.name = textBox1.Text;
            student1.sex = textBox2.Text;
            label3.Text = student1.sex + "同学" + student1.name + "说：朋友们好！";
        }
    }
    public class Person
    {
        public string name;
        private string mysex;
        public string sex
        {
            get
            {
                return mysex;
            }
            set
            {
                if (value == "男" || value == "女")
                    mysex = value;
                else
                    mysex = "性别保密";
            }
        }
    }
}
