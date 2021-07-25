//csc Entrust1.cs
//概念：委托类型表示对具有特定参数列表和返回类型的方法的引用。 通过委托，可以将方法视为可分配给变量并可作为参数传递的实体。
//https://www.cnblogs.com/yangwang365/p/10026193.html
using System;
namespace Func{
delegate void MyDel(string value);
    class Program
    {
        void Print1(string value)
        {
            Console.WriteLine("方法1:{0}", value);
        }
        void Print2(string value)
        {
            Console.WriteLine("方法2:{0}", value);
        }
        void Print3(string value)
        {
            Console.WriteLine("方法3:{0}", value);
        }
        /// <summary>
        /// 执行委托方法
        /// </summary>
        /// <param name="d">委托类型参数</param>
        /// <param name="value">委托内方法的参数</param>
        void PrintFun(MyDel d, string value)
        {
            d(value);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            MyDel del1, del2, del3;//声明委托变量

            //赋值
            del1 = p.Print1;
            del2 = p.Print2;

            //组合委托
            del3 = del1 + del2;


            //给委托赋新值
            del1 = p.Print2;


            //给委托添加方法
            del1 += p.Print3;


            //从委托移除方法
            del1 -= p.Print2;

            p.PrintFun(del1, "已运行");//调用


            Console.WriteLine("\n运行组合委托");
            p.PrintFun(del3, "已运行");
            Console.ReadKey();
        }
    }	
}

