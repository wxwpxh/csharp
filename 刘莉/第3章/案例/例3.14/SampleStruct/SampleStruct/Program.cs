using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleStruct
{
    struct Point
    {
        public int x, y;           // 字段成员
        public Point(int x, int y)  // 构造函数
        {
            this.x = x;
            this.y = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = new Point(10, 20);
            Point pt2;  // 可以先声明后赋值，不使用new关键字
            pt2.x = 20;
            pt2.y = -40;
            double distance = (pt1.x - pt2.x) * (pt1.x - pt2.x)
                + (pt1.y - pt2.y) * (pt1.y - pt2.y);
            distance = Math.Sqrt(distance);
            Console.WriteLine("两点的距离为{0}", distance);
            Console.ReadLine();

        }
    }
}
