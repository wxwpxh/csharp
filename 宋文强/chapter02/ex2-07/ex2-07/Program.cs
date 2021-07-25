using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//用浮点类型进行数值计算时可能出现的误差
namespace ex2_07
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;			//定义了三个双精度浮点类型变量
            x = 10;				//向变量x赋以常数值时，默认的数据类型为double
            y = 9.90; 				//向变量y赋以常数值时，默认的数据类型为double
            z = x - y;				//将算术表达式 x – y 的值赋给double类型变量z
            Console.WriteLine("浮点数计算{0} - {1} = {2}", x, y, z);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
