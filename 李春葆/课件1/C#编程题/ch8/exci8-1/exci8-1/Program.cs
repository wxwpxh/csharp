using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci8_1
{
    class Program
    {
        public static IEnumerable Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }

        static void Main(string[] args)
        {
            foreach (int i in Power(2, 10))
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
