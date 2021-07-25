using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormatString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,-15}{1,-40}{2,-7}", "姓名", "专业", "成绩");
            Console.WriteLine("{0,-15}{1,-40}{2,7:F2}",
                "Zhang San", "Public Management", 85);
            Console.WriteLine("{0,-15}{1,-40}{2,7:F2}",
                "Li Si", "Mechanical Engineering and Automation", 76.5);
            Console.WriteLine("{0,-15}{1,-40}{2,7:F2}",
                "Liu XiaoLong", "Automation", 83.6);
            Console.ReadLine();

        }
    }
}
