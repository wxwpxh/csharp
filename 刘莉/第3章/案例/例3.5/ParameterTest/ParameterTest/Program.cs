using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParameterTest
{
    class SampleParameter
    {
        public void Swap1(int x, int y)// 值参数
        {
            int z = x;
            x = y;
            y = z;
        }
        public void Swap2(ref int x, ref int y)// 引用参数
        {
            int z = x;
            x = y;
            y = z;
        }
        public void Add(int x, int y, out int sum)// 输出参数
        {
            sum = x + y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("请输入第一个数:");
            a = int.Parse(Console.ReadLine());
            Console.Write("请输入第二个数:");
            b = int.Parse(Console.ReadLine());
            SampleParameter smpParameter = new SampleParameter();
            smpParameter.Swap1(a, b);
            Console.WriteLine("值参数交换结果是{0},{1}", a, b);
            smpParameter.Swap2(ref a, ref b);
            Console.WriteLine("引用参数交换结果是{0},{1}", a, b);
            smpParameter.Add(a, b, out c);
            Console.WriteLine("输出参数输出结果是{0}", c);
            Console.ReadLine();

        }
    }
}
