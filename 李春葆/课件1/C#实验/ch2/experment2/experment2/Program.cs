using System;
using System.Collections.Generic;
using System.Text;

namespace experment2
{
    enum WeekDayhz { 星期日, 星期一, 星期二, 星期三, 星期四, 星期五, 星期六 };
    class Program
    {
        struct Stud			//结构类型声明应放在Main函数的外面
        {
            public int xh;		//学号
            public string xm;	//姓名
            public DateTime birthday;	//出生日期
        }
        static void Main(string[] args)
        {
            Stud s1, s2;
            s1.xh = 100; s1.xm = "李明"; s1.birthday = new DateTime(1985, 10, 18);
            s2.xh = 200; s2.xm = "王丽"; s2.birthday = new DateTime(1986, 2, 16);
            Console.WriteLine("李明的生日为{0}-{1}-{2}", s1.birthday.Year, s1.birthday.Month, s1.birthday.Day);
            Console.WriteLine("王丽的生日为{0}-{1}-{2}", s2.birthday.Year, s2.birthday.Month, s2.birthday.Day);
            int i = (int)s1.birthday.DayOfWeek;
            Console.WriteLine("{0}出生在{1}", s1.xm, (WeekDayhz)i);
            i = (int)s2.birthday.DayOfWeek;
            Console.WriteLine("{0}出生在{1}", s2.xm, (WeekDayhz)i);
            Console.WriteLine("{0}和{1}相差{2}天", s1.xm, s2.xm, s2.birthday - s1.birthday);
        }
    }
}
