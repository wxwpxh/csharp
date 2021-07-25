using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace code
{
    
    class creatCode
    { 
        char[] allchar = new char[] { '0','1','2','3','4',
                '5','6','7','8','9','A','B','C','D','E','F','G',
                'H','I','J','K','L','M','N','O','P','Q','R','S',
                'T','U','V','W','X','Y','Z','a','b','c','d','e','f','g',
                'h','i','j','k','l','m','n','o','p','q','r','s',
                't','u','v','w','x','y','z' };
        int j;
        public creatCode(int i)
        {
            this.j = i;
        }
        //线程1（thread1）的计数方法
        public  void counterCode()
        {
            int n=1;
            int i;
            Random rnd = new Random();
            lock (this)
            {
                while (n <= 3)
                {
                    Console.Write("第{0}次——", n);
                    string checkstring = string.Empty;
                    for (i = 0; i < 4; i++)
                    {
                        checkstring += allchar[rnd.Next(0, 62)];
                    }
                    Console.WriteLine("第{0}组验证码：{1}", j, checkstring);
                    n++;
                    Thread.Sleep(3000);//线程休眠3秒
                }
            }
        }
    }
}
