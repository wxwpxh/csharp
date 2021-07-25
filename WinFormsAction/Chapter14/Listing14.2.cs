using System;
using System.Globalization;

namespace FormattingSample
{
	class Program
	{
		static void Main(string[] args)
		{
			// Get the culture information for USA and Great Britain
			CultureInfo us = CultureInfo.CreateSpecificCulture("en-US");
			CultureInfo gb = CultureInfo.CreateSpecificCulture("en-GB");

			// Numeric example
			Type numType = typeof(NumberFormatInfo);
			NumberFormatInfo usNumInfo = (NumberFormatInfo)us.GetFormat(numType);
			NumberFormatInfo gbNumInfo = (NumberFormatInfo)gb.GetFormat(numType);
			Console.WriteLine("USA value is " + (49.95).ToString("c", usNumInfo));
			Console.WriteLine("GB value is " + (49.95).ToString("c", gbNumInfo));
			
			// DateTime example
			Type dtType = typeof(DateTimeFormatInfo);
			DateTimeFormatInfo usDateInfo, gbDateInfo;
			usDateInfo = (DateTimeFormatInfo)us.GetFormat(dtType);
			gbDateInfo = (DateTimeFormatInfo)gb.GetFormat(dtType);
			
			DateTime date = new DateTime(2005, 2, 24, 1, 38, 24);
			string pattern = "dd MMM yyy 'at' HH:mm tt";
			Console.WriteLine("Short date: USA {0}, GB {1}",
				date.ToString("d", usDateInfo), date.ToString("d", gbDateInfo));
			Console.WriteLine("Short time: USA {0}, GB {1}",
				date.ToString("t", usDateInfo), date.ToString("t", gbDateInfo));
			Console.WriteLine("USA pattern: " + date.ToString(pattern, usDateInfo));
			Console.WriteLine("GB pattern: " + date.ToString(pattern, gbDateInfo));
			Console.Write("Press Enter to exit.");

			Console.ReadLine();
		}
	}
}