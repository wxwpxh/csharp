//csc testlambda.cs

using System;

class testlambda
{
    static void Main() {
		int factor = 2;
		Func<int, int> multiplier = n => n * factor;
		Console.WriteLine (multiplier (3)); // 6    
	}
}
