using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 0, userNumber, guessNumber;
            Random rnd = new Random();
            guessNumber = rnd.Next(30);
            do
            {
                times++;
                Console.Write("请猜数(0~30)：");
                userNumber = int.Parse(Console.ReadLine());
                if (userNumber > guessNumber)
                    Console.WriteLine("您猜大了");
                else if (userNumber < guessNumber)
                    Console.WriteLine("您猜小了");
            }
            while (userNumber != guessNumber);
            Console.WriteLine("userNumber={0},guessNumber={1},Times={2}", userNumber, guessNumber, times);
            Console.ReadLine();

        }
    }
}
