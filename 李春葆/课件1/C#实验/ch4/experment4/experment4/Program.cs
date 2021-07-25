using System;
using System.Collections.Generic;
using System.Text;

namespace experment4
{
    class Program
    {
        const int Max = 5;
        static void disp(int[] no, string[] name, string str)
        {
            Console.WriteLine(str);
            Console.Write("学号:\t");
            for (int i = 0; i < no.Length; i++)
                Console.Write("{0}\t", no[i]);
            Console.WriteLine();
            Console.Write("姓名:\t");
            for (int i = 0; i < name.Length; i++)
                Console.Write("{0}\t", name[i]);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] no = new int[] { 2, 4, 5, 1, 3 };
            string[] name = new string[] { "Smith", "John", "Mary", "Cherr", "Tomn" };
            disp(no, name, "排序前：");
            Array.Sort(no, name);
            disp(no, name, "按学号排序后：");
            Array.Sort(name, no);
            disp(no, name, "按姓名排序后：");
        }
    }
}
