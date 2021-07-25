using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//利用控制台应用程序计算两个整数的乘积、商和余数
namespace ex5_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // BigMul()方法和DivRem()方法应用举例
            long a = 32768, b = 253, c, d;
            d = Math.BigMul((int)a, (int)b);				//变量a和b只能是32位数字
            Console.WriteLine("{0}乘以{1}的积为{2}", a, b, d);
            d = Math.DivRem(a, b, out c);
            Console.WriteLine("{0}除以{1}的商为{2}，余数为{3}", a, b, d, c);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
