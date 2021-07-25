using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace useSetValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lengths = { 2, 3 };
            int[] lowerBounds = { 1, 10 };
            Array ComputerLanguage = Array.CreateInstance(typeof(string), lengths, lowerBounds);
            ComputerLanguage.SetValue("C++", 1, 10);
            ComputerLanguage.SetValue("Java", 1, 11);
            ComputerLanguage.SetValue("C#", 1, 12);
            ComputerLanguage.SetValue("Pascal", 2, 10);
            ComputerLanguage.SetValue("Fortran", 2, 11);
            ComputerLanguage.SetValue("COBOL", 2, 12);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(ComputerLanguage.GetValue(i+1,j+10));
                }
            }
            Console.Read();
        }
    }
}
