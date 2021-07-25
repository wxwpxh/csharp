using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex4_08
{
    public class Person				//新创建的自定义类Person
    {
        public string name, sex;
        public virtual string talk()	//使用virtual关键字定义了talk()方法，允许覆盖
        {
            return "朋友们好！";
        }
    }
    public class Student : Person	//以Person为基类，创建了Student类
    {
        public int grade;			//派生类中添加的数据成员
        public string major;
    }
    public class Teacher : Person	//以Person为基类，创建了Teacher类
    {
        public string Course, Department;	//派生类中添加的数据成员
        public override string talk()		//使用override关键字对基类中的talk()方法形成覆盖
        {
            return "同学们好！";
        }
    }

}
