using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//编写控制台应用程序，计算一个指定日期到另一个指定日期之间的天数
namespace ex5_18
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = DateTime.Now;						//获取当前系统日期/时间
            DateTime dt2 = new DateTime(2009, 10, 1, 10, 0, 0);	//获得2009-10-1 10:00:00
            TimeSpan ts1 = dt2.Subtract(dt1);					//计算两个日期之间的差值
            Console.WriteLine("从{0:D}到{1:D}还有{2}天{3}小时{4}分", dt1, dt2, ts1.Days, ts1.Hours, ts1.Minutes);
            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
