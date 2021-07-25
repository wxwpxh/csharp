using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//在Windows窗体应用程序中声明名为Person的类，为其定义可以重载的方法和构造函数，并分别使用不同数量和内容的实际参数，在程序中通过Person类创建了几个实例。用标签控件label1在窗体上输出信息
namespace ex4_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Person student1 = new Person();				//调用不带参数的构造函数
            label1.Text += student1.sex + "同学" + student1.name + "说：";
            label1.Text += student1.talk("问候");
            Person student2 = new Person("王雪蕊", "女");	//调用带两个参数的构造函数
            label1.Text += student2.sex + "同学" + student2.name + "说：";
            label1.Text += student2.talk("自我介绍");
            Person student3 = new Person("谢俊鹏");			//调用带一个参数的构造函数
            label1.Text += student3.sex + "同学" + student3.name + "说：";
            label1.Text += student3.talk();

        }
    }

    public class Person
    {
        public string name, sex;
        public Person(string myname, string mysex)			//具有两个参数的构造函数
        {
            this.name = myname;							//这里的this指对象本身
            this.sex = mysex;
        }
        public Person(string myname)						//具有一个参数的构造函数
        {
            this.name = myname;
            this.sex = "性别保密";
        }
        public Person()									//没有参数的构造函数
        {
            this.name = "无名氏";
            this.sex = "性别保密";
        }
        public string talk(string word)					//具有一个参数的talk()方法
        {
            if (word == "问候")
                return "朋友们好！\n\n";
            else
                return "我是一个学生！\n\n";
        }
        public string talk()							//没有参数的talk()方法
        {
            return "呵呵……我很激动，不知道该说什么好了！\n\n";
        }
    }

}
