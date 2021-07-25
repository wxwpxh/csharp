using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//用decimal类型进行带有小数的数值计算时可以避免误差
namespace ex2_08
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x, y, z;
            x = 10M;				//decimal类型的常数值后面必须跟一个M或m
            y = 9.9M;
            z = x - y;
            Console.WriteLine("十进制小数计算{0} - {1} = {2}", x, y, z);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
