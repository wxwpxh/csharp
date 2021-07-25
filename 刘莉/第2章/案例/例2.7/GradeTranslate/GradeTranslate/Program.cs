using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeTranslate
{
    class Program
    {
        static void Main(string[] args)
        {
            double score;
            string grade;
            Console.Write("请输入成绩（0~100）：");
            score = double.Parse(Console.ReadLine());
            if (score >= 90)
                grade = "优";
            else if (score >= 80)
                grade = "良";
            else if (score >= 70)
                grade = "中";
            else if (score >= 60)
                grade = "及格";
            else
                grade = "不及格";
            Console.WriteLine("您的成绩为{0}，等级为{1}", score, grade);
            Console.ReadLine();

        }
    }
}
