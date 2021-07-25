using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeTest
{
    class Employee
    {
        private string name;
        private int age;
        private double salary = 3000;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = Math.Abs(value); }
        }
        public double Salary
        {
            get { return salary; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee ps = new Employee();
            //  ps.name = "李明";//  错误为私有访问控制不能从类的外部访问
            //  ps.age = 25;//  错误为私有访问控制不能从类的外部访问
            ps.Name = "李明";
            ps.Age = -25;// set访问器会将其求绝对值，赋值给salary字段
            //  ps.Salary = 4000; //  错误,该属性没有set方法，不能在外部赋值
            Console.WriteLine("姓名:{0},年龄：{1},工资：{2}",
                ps.Name, ps.Age, ps.Salary);
            Console.ReadLine();

        }
    }
}
