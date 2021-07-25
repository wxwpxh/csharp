using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//当两个数值变量之间执行逻辑运算时，其结果将按位计算获得
namespace ex2_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 204, b = 121;	     	//相当于二进制数10101010和01111001
            int c1 = a & b;    			//c1的值是a和b按位相“与”的结果
            int c2 = a | b;     			//c2的值是a和b按位相“或”的结果
            int c3 = a ^ b;   				//c3的值是a和b按位相“异或”的结果
            /*
              完成计算之后，再将计算结果转换成十进制数和十六进制数如下：
            c1=72 （十六进制数0x48）
            c2=253（十六进制数0xFD）
            c3=181（十六进制数0xB5）
            */
            Console.WriteLine("c1={0}", c1);
            Console.WriteLine("c2={0}", c2);
            Console.WriteLine("c3={0}", c3);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
