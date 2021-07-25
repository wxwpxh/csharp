using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VariableOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;  // int为数据类型，number1为变量名称
            int number2, sum;  // 一个语句声明多个同类型变量
            Console.Write("请输入number2的值:");//输出提示信息
            number2 = int.Parse(Console.ReadLine());//读入字符串，转换为int类型
            sum = number1 + number2;
            Console.WriteLine("{0} + {1} = {2}", number1 ,number2 , sum);  // 输出变量及运算信息到显示器
            Console.WriteLine("The Sum is {0}", sum);  // 输出相应信息到显示器
            Console.ReadLine();  // 等待用户输入，这样可以观察运行结果

        }
    }
}
