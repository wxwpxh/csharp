using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaysofMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            int days, month;
            Console.Write("请输入月份：");
            month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 2:
                    days = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                default:
                    days = 31;
                    break;
            }
            Console.WriteLine("{0}月份有{1}天", month, days);
            Console.ReadLine();

        }
    }
}
