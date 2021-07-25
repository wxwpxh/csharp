using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//编写控制台应用程序，计算Sin（45°），结果精确到小数点后3位数
namespace ex5_05
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Angle = Math.PI / 180;	//定义角度每1°的弧度值
            double s = Math.Sin(45 * Angle);
            s = Math.Round(s, 3);			//结果四舍五入，精确到小数点后3位数
            Console.WriteLine("Sin 45°= {0}", s);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
