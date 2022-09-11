using System;

namespace ATMApp.UI
{
	public static class Utility
	{
		public static void PrintMessage(string msg, bool success)
		{
			
			if(success)
				Console.ForegroundColor = ConsoleColor.Yellow;
			else 
				Console.ForegroundColor = ConsoleColor.Red;

			Console.WriteLine(msg);
			Console.ResetColor();
            PressEnterToContinue();

        }
		 public static string GetUserInput(string prompt)
		 {
			Console.WriteLine($"Enter {prompt}");
			return Console.ReadLine();
			
			
		}
		public static void PressEnterToContinue()
		{
			Console.WriteLine("\n\nPress Enter to continue...\n");
			Console.ReadLine();
		}
	}
}