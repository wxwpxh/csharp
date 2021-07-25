	//csc Cal.cs

	using System;
	class Cal
	{
	static class Calculator {
		public static T Add<T>(T t1, T t2) {
			dynamic d1 = t1;
			dynamic d2 = t2;
	 
			return (T)(d1 + d2);
		}
	}
	 
	public static void Main(string[] args){
		int i = Calculator.Add(1, 2);
		double d = Calculator.Add(1.1, 2.2);
		string s = Calculator.Add("abc", "def");
	 
		Console.WriteLine(i + " " + d + " " + s);
		}
	}　　