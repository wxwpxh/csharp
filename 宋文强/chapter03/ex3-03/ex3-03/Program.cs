using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//通过控制台接收键盘输入的圆半径，计算出圆的面积，并通过控制台输出计算结果
namespace ex3_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, pi, area;
            string s;
            Console.Write("请键盘输入一个半径的值：");
            s = Console.ReadLine();
            r = double.Parse(s);		//把ReadLine()方法返回的字符串转换成数值
            area = 3.14159 * r * r;
            Console.WriteLine("半径为{0}的圆面积 = {1}", r, area);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
