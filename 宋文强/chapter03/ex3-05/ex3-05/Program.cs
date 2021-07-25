using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;			//为了引用CultureInfo类，必须导入这个命名空间

//在控制台应用程序中，利用System.Globallization.CultureInfo类表达具有国家/地区特征的货币格式信息
namespace ex3_05
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("en-US");  //中国的格式代码为"zh-CN"
            double pay = 2750;
            string mypay = string.Format(ci, "张三丰五月份的工资为 {0:c}", pay);
            Console.WriteLine(mypay);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
