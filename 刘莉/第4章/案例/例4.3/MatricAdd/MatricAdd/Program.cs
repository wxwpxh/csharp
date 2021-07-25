using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatricAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayA = new int[,] { { 8, 3, 4 }, { 1, 5, 9 }, { 6, 7, 2 } };
            int[,] arrayB = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] arrayC = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    for (int k = 0; k < 3; k++)
                        arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            Console.WriteLine("矩阵A:");
            DisplayMatric(arrayA);
            Console.WriteLine("矩阵B:");
            DisplayMatric(arrayB);
            Console.WriteLine("矩阵C=A+B:");
            DisplayMatric(arrayC);
            Console.ReadLine();
        }
        public static void DisplayMatric(int[,] matric)
        {
            for (int i = 0; i < matric.GetLength(0); i++)
            {
                for (int j = 0; j < matric.GetLength(1); j++)
                {
                    Console.Write("{0,5}", matric[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
