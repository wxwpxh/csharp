using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodTest
{
    class SimpleMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public static int Max(int x, int y)
        {
            if (x > y)
                return x;
            else
                return y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("请输入第一个数:");
            a = int.Parse(Console.ReadLine());
            Console.Write("请输入第二个数:");
            b = int.Parse(Console.ReadLine());
            SimpleMath smpMath = new SimpleMath();
            Console.WriteLine("两个数的和是{0}", smpMath.Add(a, b));
            // Add为静态方法，所以必须创建类的实例，然后调用方法
            Console.WriteLine("两数的大数是{0}", SimpleMath.Max(a, b));
            // Max为静态方法，所以要类名调用方法
            Console.ReadLine();

        }
    }
}
