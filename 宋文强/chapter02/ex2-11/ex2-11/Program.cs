using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * 将三基色（R、G、B）表示的彩色像素转换成灰度像素的计算公式为
               Gray = 0.30R + 0.59G + 0.11B
根据这个公式计算出任意一个指定像素的灰度值。
*/
namespace ex2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            byte gray;
            byte r = 240, g = 201, b = 129;				//像素的三基色分量值
            gray = (byte)(0.30 * r + 0.59 * g + 0.11 * b);	//显式转换成byte类型
            Console.WriteLine("计算得到的像素灰度值 = {0}", gray);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
