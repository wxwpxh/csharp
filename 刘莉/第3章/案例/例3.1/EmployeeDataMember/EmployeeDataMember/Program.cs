using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeDataMember
{
    class Employee // 类的定义，class是保留字，表示定义一个类，Employee是类名
    {
        public readonly int id;  // 类的只读字段声明
        public string name;  // 类的字段声明
        public int age = 20;   // 类的字段声明，可以在声明同时赋值，
        public const int minAge = 18; // 类的常量声明，必须同时赋值，不可改变
        public static string companyName;  // 类的静态字段（数据）声明
        public void Display()// 类的方法(函数)声明，显示姓名、年龄和公司
        {
            Console.WriteLine("姓名:{0},年龄：{1},公司：{2}",
                name, age, companyName);
            // this.name, this.age, Employee.companyName);可以这种形式访问
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee.companyName = "ABC";// 静态字段须用类名来引用
            Employee emp1 = new Employee();
            emp1.name = "李明";
            emp1.age = 25;
            // emp1.id = 1001; 错误，只读字段只能在声明时或构造函数中赋值
            Employee.companyName = "ABC";// 类的静态字段须用类名来引用
            if (emp1.age < Employee.minAge)// 常量须用类名来引用
                Console.WriteLine("不符合最低年龄要求");
            else
                Console.WriteLine("姓名:{0},年龄：{1},公司：{2}",
                    emp1.name, emp1.age, Employee.companyName); ;
            Employee emp2 = new Employee();
            emp2.Display();// 调用类的方法
            Console.ReadLine();

        }
    }
}
