using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayCopy
{
    class Person
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] nArray1 = { 1, 2 };
            int[] nArray2 = nArray1;
            int[] nArray3 = (int[])nArray1.Clone();
            Person[] personArray1 = 
            {
                new Person("李俊", 25),
                new Person("周玲", 32),
            };
            Person[] personArray2 = personArray1;
            Person[] personArray3 = (Person[])personArray1.Clone();
            nArray1[0] = 11;
            personArray1[0].Name = "张敏";
            Console.WriteLine("nArray1[0]的值：{0}", nArray1[0]);
            Console.WriteLine("nArray2[0]的值：{0}", nArray2[0]);
            Console.WriteLine("nArray3[0]的值：{0}", nArray3[0]);
            Console.WriteLine("personArray1[0].Name的值：{0}",
                 personArray1[0].Name);
            Console.WriteLine("personArray2[0].Name值：{0}",
                 personArray2[0].Name);
            Console.WriteLine("personArray3[0].Name值：{0}",
                 personArray3[0].Name);
            Console.ReadLine();

        }
    }
}
