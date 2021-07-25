using System;

namespace mysum
{
    class mysum
    {
        static void Main(string[] args)
        {
            int sum=0;
            for(int i=1;i<=100;i++)
                sum+=i;
            Console.WriteLine("Sum={0}",sum);
            Console.WriteLine("Hello World!");
        }
    }
}
