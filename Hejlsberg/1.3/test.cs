//csc test.cs
using System;

class Test
{
    static void Main() {
        int i = 123;
        object o = i;           // Boxing
        int j = (int)o;         // Unboxing
		
		Console.WriteLine( " i=" + i + ";o= " + o + ";j =" + j);

    }
}