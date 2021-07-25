using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayParameterTest
{
    class StringEx
    {
        public static string Combine(params string[] substrings)
        {
            string result = string.Empty;
            foreach (string substring in substrings)
                result += substring;
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringEx.Combine("ABC", "123"));
            Console.WriteLine(StringEx.Combine("I", " like", " C#!"));
            Console.ReadLine();

        }
    }
}
