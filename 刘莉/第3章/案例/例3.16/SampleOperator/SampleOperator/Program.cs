using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleOperator
{
    struct Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = new Point(10, 6);
            Point pt2 = new Point(5, 8);
            Point pt3 = pt1 + pt2;
            Point pt4 = pt1 - pt2;
            Console.WriteLine("pt1+pt2 x={0},y={1}", pt3.x, pt3.y);
            Console.WriteLine("pt1-pt2 x={0},y={1}", pt4.x, pt4.y);
            Console.ReadLine();

        }
    }
}
