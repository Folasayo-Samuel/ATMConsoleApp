using System;

namespace ATMApp.UI
{
	public static class AppScreen
	{
		internal static void Welcome()
		{
						// Clears the console screen
			Console.Clear();
			// Sets the title of the console window
			Console.Title = "My ATM App";
			// set the console text color 
			Console.ForegroundColor = ConsoleColor.White;

			// Set the welcome message
			Console.WriteLine("\n\n------------ Welcome to my ATM App ------------\n");

			// Prompt the user to insert ATM card
			Console.WriteLine("Please insert your ATM card");
			Console.WriteLine("Note: Actual ATM machine will accept and validate a physical ATM card, read the card number and validate it");

            Utility.PressEnterToContinue();
        }
		
		
	}
}