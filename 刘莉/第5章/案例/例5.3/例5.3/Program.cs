using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 例5._3
{
    class Program
    {
        // 交换任意两个数的方法
        static void Swap<T>(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Console.WriteLine("交换前：a={0},b={1}", a, b);
            // 调用泛型方法：指定类型参数int
            Swap<int>(ref  a, ref  b);
            Console.WriteLine("交换后：a={0},b={1}", a, b);
            double c = 1.1;
            double d = 2.2;
            Console.WriteLine("交换前：c={0},d={1}", c, d);
            // 调用泛型方法：可以省略类型参数double，编译器将推断出该参数类型
            Swap(ref c, ref d);
            Console.WriteLine("交换后：c={0},d={1}", c, d);
        }
    }
}
