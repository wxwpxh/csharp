using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * 在Windows窗体应用程序中声明名为Person的类，为其定义可以重载的talk()方法，并在程序中引用通过Person类创建的对象，调用talk()方法时分别使用了内容和数量不同的实际参数
 */
namespace ex4_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person student1 = new Person();
            student1.name = textBox1.Text;
            student1.sex = textBox2.Text;
            label4.Text = student1.sex + "同学" + student1.name + "说：";
            if (comboBox1.Text == "")		//未选择“发言”选项，调用无参数的方法重载形式
                label4.Text += student1.talk();
            else						//选择了“发言”选项，调用有参数的方法重载形式
                label4.Text += student1.talk(comboBox1.Text);

        }
    }

    public class Person							//定义Person类拥有可以重载的方法
    {
        public string name;						//公有字段
        private string mysex;					//私有字段
        public string sex						//定义一个既可读又可写的属性sex
        {
            get								//读取属性值的访问器
            {
                return mysex;
            }
            set								//设置属性值的访问器
            {
                if (value == "男" || value == "女")	//若sex属性赋值为“男”或“女”
                    mysex = value;				//把属性赋值保存到mysex
                else							//若sex属性赋值为其它
                    mysex = "性别保密";			//把“性别保密”赋值保存到mysex
            }
        }
        public string talk()					//没有参数的talk()方法
        {
            return "呵呵……我很激动，不知道该说什么！";
        }
        public string talk(string word) 			//有一个参数的talk()方法
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
