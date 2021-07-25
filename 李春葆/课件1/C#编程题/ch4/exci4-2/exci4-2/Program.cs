using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Max = 5;                          //考生数
            int[] Ave = new int[Max];                   //定义一个一维数组存储考生的总成绩
            int[,] grade ={{88,75,62,84},{96,85,75,92},  //定义二维数组存储考生成绩
                          {68,63,72,78},{95,89,76,98},
                          {76,65,72,63}};
            for (int i = 0; i < Max; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Ave[i] += grade[i, j];       //累加考生成绩
                }
            }
            for (int k = 0; k < Max; k++)
                Console.WriteLine("考生{0}平均成绩={1} ", k + 1, Ave[k] / 4.0);
        }
    }
}
