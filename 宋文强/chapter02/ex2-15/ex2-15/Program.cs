using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * 专家认为，青年男子标准体重计算公式应为：
标准体重（kg）= 身高（cm）-105
正常体重应在标准体重±10%的范围内，否则就是偏瘦或偏胖。写出判断体重是否在正常范围的逻辑表达式如下：
体重 >= (身高 - 105) * 0.9 && 体重 <= (身高 - 105) * 1.1
*/
namespace ex_15
{
    class Program
    {
        static void Main(string[] args)
        {
            float height, weight;
            bool normal;			//用来保存逻辑表达式值的布尔型变量
            height = 175;			//身高
            weight = 70;			//体重
            normal = weight >= (height - 105) * 0.9 && weight <= (height - 105) * 1.1;

            if (normal == true)
                Console.Write("体重正常");
            else
                Console.Write("体重未在正常范围内");

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
