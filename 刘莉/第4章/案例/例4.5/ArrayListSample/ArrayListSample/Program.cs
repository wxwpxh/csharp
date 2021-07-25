using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ArrayListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Fortran"); //添加元素
            list.Add("Cobol");
            list.Add("Basic");
            list.Add("Pascal");
            list.Add("C/C++");
            list.Add("Java");
            list.Add("C#");
            list.Sort();  //排序
            list.Remove("Basic"); //移除指定成员
            foreach (string course in list)
                Console.Write("{0,10}", course);
            Console.WriteLine();
            Console.WriteLine("Count={0},Capacity={1}", list.Count, list.Capacity);
            list.Clear();  //清除所有元素
            Console.WriteLine("Count={0},Capacity={1}", list.Count, list.Capacity);
            list.TrimToSize();
            Console.WriteLine("Count={0},Capacity={1}", list.Count, list.Capacity);
            Console.ReadLine();

        }
    }
}
