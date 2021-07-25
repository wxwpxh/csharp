using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexer
{
    class SampleIndex
    {
        //  可容纳5个整数的整数集
        private double[] arr = new double[5] { 1, 2, 3, 4, 5 };
        public double this[int index]         //  声明索引器
        {
            get
            { //  检查索引范围
                if (index < 0 || index >= 5)
                {
                    return 0;
                }
                else
                {
                    return arr[index];
                }
            }
            set
            {
                if (index >= 0 || index < 5)
                {
                    arr[index] = value;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SampleIndex smpIndex = new SampleIndex();
            smpIndex[3] = 3.5;
            // smpIndex[5] = 17.5;// 错误，索引超出范围
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("smpIndex[{0}]={1}", i, smpIndex[i]);
            }
            Console.ReadLine();

        }
    }
}
