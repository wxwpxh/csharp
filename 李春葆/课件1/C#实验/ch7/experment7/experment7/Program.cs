using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace experment7
{
    class MyGen<T>
    {
        List<T> list = new List<T>();
        public void add(T t)
        {
            list.Add(t);
        }
        public void Displist()
        {
            foreach (var i in list)
                Console.Write("{0} ",i);
            Console.WriteLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyGen<int> obj1 = new MyGen<int>();
            Console.WriteLine("向obj1对象中添加3个整数");
            obj1.add(1);
            obj1.add(2);
            obj1.add(3);
            Console.Write("obj1对象中的元素:");
            obj1.Displist();

            MyGen<string> obj2 = new MyGen<string>();
            Console.WriteLine("向obj2对象中添加4个字符串");
            obj2.add("C++");
            obj2.add("Java");
            obj2.add("VB");
            obj2.add("C#");
            Console.Write("obj2对象中的元素:");
            obj2.Displist();

            Type t = obj1.GetType();
            MethodInfo[] m = t.GetMethods();
            Console.WriteLine("obj1对象的类型的方法个数:{0}",m.Length);
            if (m.Length > 0)
            {
                Console.WriteLine("方法如下:");
                foreach (MethodInfo item in m)
                    Console.WriteLine("\t{0} ", item.Name);
            }
        }
    }
}
