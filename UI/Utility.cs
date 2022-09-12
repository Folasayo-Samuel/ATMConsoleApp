using System.Text;
using System;

namespace ATMConsoleApp.UI
{
	public static class Utility
	{
		public static string GetSecretInput(string prompt)
		{
			var isPrompt = true;
			var asterisk = "";

			var input = new StringBuilder();
			
			while(true)
			{
				if(isPrompt)
				
					Console.WriteLine(prompt);
				isPrompt = false;

				var inputKey = Console.ReadKey(true);
				
				if(inputKey.Key == ConsoleKey.Enter)
					if (input.Length == 8)
					{
						break;
					}
					else
					{
						PrintMessage("\nPlease enter 8 digits.", false);
						input.Clear();
						isPrompt = true;
						continue;
					}

				if (inputKey.Key == ConsoleKey.Backspace && input.Length > 0)
				{
					input.Remove(input.Length - 1, 1);
				}
				else if (inputKey.Key != ConsoleKey.Backspace)
				{
					input.Append(inputKey.KeyChar);
					Console.Write(asterisk + "*");
				}
			}
			return input.ToString(); 

		}
		public static void PrintMessage(string msg, bool success)
		{
			
			if(success)
				Console.ForegroundColor = ConsoleColor.Yellow;
			else 
				Console.ForegroundColor = ConsoleColor.Red;

			Console.WriteLine(msg);
			Console.ForegroundColor = ConsoleColor.White;
			PressEnterToContinue();

		}
		 public static string GetUserInput(string prompt)
		 {
			Console.WriteLine($"Enter {prompt}");
			return Console.ReadLine();
			
			
		}
		
		public static void PrintDotAnimation(int timer = 10)
		{
		
			for(int i = 0; i < timer; i++)
			{
				Console.Write(".");
				Thread.Sleep(200);
			}
			Console.Clear();
		}
		public static void PressEnterToContinue()
		{
			Console.WriteLine("\n\nPress Enter to continue...\n");
			Console.ReadLine();
		}
	}
}