using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, c, n;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            if (n > 13)
                Console.WriteLine("输入的数值太大！");
            else
            {
                for (i = 0; i <= n - 1; i++)
                {
                    for (j = 1; j < 15 - i; j++)
                        Console.Write("  ");  	    //每次循环显示2个空格
                    c = 1;
                    Console.Write("{0}   ", c);
                    for (j = 1; j <= i; j++)
                    {
                        c = c * (i - j + 1) / j;
                        if (c < 100)
                            if (c < 10)
                                Console.Write("{0}   ", c);  //显示3个空格
                            else
                                Console.Write("{0}  ", c);   //显示2个空格
                        else
                            Console.Write("{0} ", c);     	//显示1个空格
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
