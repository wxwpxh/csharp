using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceImplement
{
    interface IPersonalIncome
    {
        double Income { get; }
        // 声明一个属性，该属性相当于声明了两个方法，属性后面不需加;
        // public void DisplayIncome( )
        // 错误。1.不能加任何修饰符，2.方法后面要加分号
        void DisplayIncome();// 声明一个方法。
    }
    class Student : IPersonalIncome
    {
        private string name;
        private double subvention;
        private double scholarship;
        private double grants;
        public Student(string name, double subvention, double scholarship, double grants)
        {
            this.name = name;
            this.subvention = subvention;
            this.scholarship = scholarship;
            this.grants = grants;
        }
        public double Income
        {
            get
            {
                return subvention + scholarship + grants;
            }
        }
        public void DisplayIncome()
        {
            Console.WriteLine("{0},是一名学生，总收入{1}", name, Income);
        }
    }
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
    class Manager : Employee, IPersonalIncome
    {
        public double Bonus { get; set; }
        public Manager(string name, int age, double salary, double bonus)
            : base(name, age, salary)
        {
            Bonus = bonus;
        }
        public double Income
        {
            get
            {
                return Salary + Bonus;
            }
        }
        public void DisplayIncome()
        {
            Console.WriteLine("{0},是一名经理，总收入{1}", Name, Income);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("肖红", 1000, 300, 200);
            Manager mng1 = new Manager("李文", 36, 5000, 6000);
            stu1.DisplayIncome();
            mng1.DisplayIncome();
            Console.ReadLine();

        }
    }
}
