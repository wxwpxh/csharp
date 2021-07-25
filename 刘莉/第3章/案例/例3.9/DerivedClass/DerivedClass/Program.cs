using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DerivedClass
{
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
        public virtual void Display()
        {
            Console.WriteLine("姓名:{0},年龄：{1},工资:{2}", Name, Age, Salary);
        }
    }
    class Manager : Employee
    {
        public double Bonus { get; set; }
        public Manager(string name, int age, double salary, double bonus)
            : base(name, age, salary)
        {
            Bonus = bonus;
        }
        public override void Display()
        {
            Console.WriteLine("姓名:{0},年龄：{1},工资:{2}", Name, Age, Salary + Bonus);
        }
        //public override void Display()
        //{
        //    base.Display();
        //    Console.WriteLine("奖金:{0},总收入：{1}", Bonus, Salary + Bonus);
        //}


    }
    class Program
    {
        static void Main(string[] args)
        {
            Manager mng = new Manager("王军", 45, 4000, 3758.26);
            mng.Display();
            Console.ReadLine();

        }
    }
}
