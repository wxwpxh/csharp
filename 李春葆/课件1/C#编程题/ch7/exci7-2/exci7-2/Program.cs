using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace exci7_2
{
    class Program
    {
        public class MyClass
        {
            int x;
            protected int y;
            public int z;
            public MyClass()
            {
                x = y = z = 0;
            }
            public MyClass(int a, int b, int c)
            {
                x = a;
                y = b;
                z = c;
            }
            public int getx()
            {
                return x;
            }
            public int gety()
            {
                return y;
            }

        }
        static void Main(string[] args)
        {
            string classname = "MyClass";
            Console.WriteLine("{0}类", classname);
            Type t = typeof(MyClass);
            MemberInfo[] m = t.GetMembers();
            Console.WriteLine("  {0}的成员个数:{1}", t.FullName, m.Length);
            foreach (MemberInfo item in m)
                Console.WriteLine("\t{0,12} {1,10} ", item.Name, item.MemberType);
        }
    }
}
