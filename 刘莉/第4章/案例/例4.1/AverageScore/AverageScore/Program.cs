using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AverageScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score;
            Random rnd = new Random();
            int n, sum = 0, overAvg = 0;
            double avgScore;
            Console.Write("请输入学生人数n:");
            n = int.Parse(Console.ReadLine());
            score = new int[n];
            for (int i = 0; i < score.Length; i++)
            {
                score[i] = rnd.Next(101);
                sum += score[i];
            }
            avgScore = (double)sum / n;
            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] > avgScore)
                    overAvg++;
            }
            Console.WriteLine("{0}个学生的平均成绩为{1:f2},高于平均成绩人数{2}", n, avgScore, overAvg);
            Console.ReadLine();

        }
    }
}
