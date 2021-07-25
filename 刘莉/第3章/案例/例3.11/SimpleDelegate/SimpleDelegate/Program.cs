using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDelegate
{
    public delegate int NumberOperate(int x, int y);
    public class SimpleMath
    {
        public static int Add(int x, int y)
        { return x + y; }
        public static int Sub(int x, int y)
        { return x - y; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            NumberOperate NumOp = new NumberOperate(SimpleMath.Add);
            Console.WriteLine("{0} + {1} = {2}", a, b, NumOp(a, b));
            NumOp = new NumberOperate(SimpleMath.Sub);
            Console.WriteLine("{0} - {1} = {2}", a, b, NumOp(a, b));
            Console.ReadLine();

        }
    }
}
