using System;
using System.Text;
using System.Windows.Forms;

namespace ex4_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //注意，这里的Teacher类和Student类都在Person.cs中，且都是继承的Person类
        //在如下程序中，Person类只包含name、sex两个公有数据成员和talk()方法。
        //Student类在继承了Person类的公有成员的同时，还添加了两个新的公有数据成员grade、major。
        //Teacher类不仅继承了Person类的公有成员，还添加了Course、Department两个新的数据成员，
        //并且以重新定义的talk()方法覆盖了基类中的同名方法。
        //因此，实例对象stu1的talk()方法是从Person类继承而来的，而teach1的talk()方法则来自子类Teacher，二者的其执行结果是不一样的
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "教师")
            {
                Teacher teach1 = new Teacher();
                teach1.name = textBox1.Text;
                teach1.sex = textBox2.Text;
                teach1.Course = textBox3.Text;
                teach1.Department = textBox4.Text;
                label1.Text = teach1.talk() + "\n";
                label1.Text += "我叫" + teach1.name + "，是" + teach1.Department + "的" + teach1.Course;
            }
            else
            {
                Student stu1 = new Student();
                stu1.name = textBox1.Text;
                stu1.sex = textBox2.Text;
                stu1.grade = int.Parse(textBox3.Text);
                stu1.major = textBox4.Text;
                label1.Text += stu1.talk() + "\n";
                label1.Text += "我叫" + stu1.name + "，是" + stu1.grade + "级" + stu1.major + "专业学生";
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "教师")
            {
                label4.Text = "职称：";
                label5.Text = "部门：";
            }
            else
            {
                label4.Text = "年级：";
                label5.Text = "专业：";
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
