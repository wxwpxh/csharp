using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//引用符号常量，分别计算多个用户应缴纳电费的控制台应用程序。
namespace ex2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            const float price = 0.75f;				//定义符号常量price
            float userA = 48, userB = 62, userC = 83;
            float expensesA, expensesB, expensesC;
            expensesA = userA * price;				//引用常量price的计算表达式
            expensesB = userB * price; 				//引用常量price的计算表达式
            expensesC = userC * price; 				//引用常量price的计算表达式
            Console.WriteLine("用户A应缴纳电费：{0}", expensesA);
            Console.WriteLine("用户B应缴纳电费：{0}", expensesB);
            Console.WriteLine("用户C应缴纳电费：{0}", expensesC);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
