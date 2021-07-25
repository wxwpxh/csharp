using System;
using System.Media;

namespace SoundSample
{
	class Program
	{
		static void Main(string[] args)
		{
			SoundPlayer player = new SoundPlayer(@"C:\WINDOWS\Media\ringin.wav");

			Console.WriteLine("Execution waits while sound plays with PlaySync");
			player.PlaySync();
			
			Console.WriteLine("Execution continues while sound plays with Play");
			player.Play();
			Console.WriteLine("This displays while sound is playing.");
			
			Console.Write("Press Enter to exit.");
			Console.ReadLine();
		}
	}
}
