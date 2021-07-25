using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Instance_Constructor
{
     

    class Employee
    {
        private string name;
        public int Age { get; set; }// 自动属性
        private double salary = 2000;
         static Employee()
        {
            Console.WriteLine("欢迎来到员工管理系统");
        }
        public double Salary // 为字段建立关联属性
        {
            get { return salary; }
            set { salary = value; }
        }
        public Employee(string name)
        {
            this.name = name;
        }
        // 可重载构造函数。
        public Employee(string name, int age, double salary)
        {
            this.name = name;// 类成员与参数同名，可加this.引用类成员
            this.Age = age;
            this.salary = salary;
        }
        public void Display()
        {
            // Console.WriteLine("姓名:{0},年龄：{1},工资:{2}", name, age,salary);
            // 自动属性Age会为类创建一个相关联的私有匿名字段，不能用age访问
            Console.WriteLine("姓名:{0},年龄：{1},工资:{2}", name, Age, salary);
        }
      
    }


    class Program
    {
        static void Main(string[] args)
        { 
            // Employee emp1 = new Employee( );
 
            // 错误，因为已有了显式的构造函数，则默认的构造函数失效。
            Employee emp1 = new Employee("李明");// 创建类的实例
            // 没有设置年龄和工资，所以取默认值和初始值
            emp1.Display();
            Employee emp2 = new Employee("王辉", 25, 4500);// 创建类的实例
            emp2.Display();
            // Employee emp3 = new Employee("李彤", 25);// 错误，没有对应的构造函数
            // Employee emp4 = new Employee("孙健") { Age = 30, salary = 5000 };
            // salary为私有，不能访问
            Employee emp4 = new Employee("孙健") { Age = 30, Salary = 5000 };
            emp4.Display();
            Console.ReadLine();

        }

    }
}
