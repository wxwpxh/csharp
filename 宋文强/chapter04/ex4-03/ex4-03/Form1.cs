using System;
using System.Text;
using System.Windows.Forms;

namespace ex4_03
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
            label4.Text = student1.sex + "同学" + student1.name + "说：";
            if (comboBox1.Text == "")
                label4.Text += student1.talk();
            else
                label4.Text += student1.talk(comboBox1.Text);
        }
    }
    public class Person
    {
        public string name;						//公有字段
        private string mysex;					//私有字段
        public string sex						//定义一个既可读又可写的属性sex
        {
            get								    //读取属性值
            {
                return mysex;
            }
            set								    //设置属性值
            {
                if (value == "男" || value == "女")	//若sex属性赋值为“男”或“女”
                    mysex = value;				//把属性赋值保存到mysex
                else							//若sex属性赋值为其它
                    mysex = "性别保密";			//把“性别保密”赋值保存到mysex
            }
        }
        public string talk()
        {
            return "呵呵……我很激动，不知道该说什么！";
        }
        public string talk(string word)
        {
            if (word == "自我介绍")
                return "我是一个学生。";
            else if (word == "问候")
                return "朋友们好！";
            else
                return "我对各位的敬仰如滔滔江水……";
        }
    }
}
