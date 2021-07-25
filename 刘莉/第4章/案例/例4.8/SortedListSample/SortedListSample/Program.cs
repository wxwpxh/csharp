using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SortedListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList students = new SortedList();
            students.Add("105", "王涛");
            students.Add("102", "李雨");
            students.Add("108", "郭晨");
            students.Add("101", "杨云");
            students.Add("106", "张鑫");
            foreach (DictionaryEntry student in students)
            {
                Console.WriteLine("{0}, {1}", student.Key, student.Value);
            }
            Console.ReadLine();

        }
    }
}
