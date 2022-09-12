using ATMConsoleApp.Domain.Entities;
namespace ATMConsoleApp.UI
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
		
		internal static UserAccount UserLoginForm()
		{
			var tempUserAccount = new UserAccount();

			tempUserAccount.CardNumber = Validator.Convert<long>("your card number.");
			tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your card PIN"));
			return tempUserAccount;
		}
		
		internal static void LoginProgress()
			{
				Console.WriteLine("\nChecking card number and PIN...");
			Utility.PrintDotAnimation();
		}
		
		internal static void PrintLockScreen()
		{
			Console.Clear();
			Utility.PrintMessage("Your account is locked. Please go to the nearest branch to unlock your account. Thanks you", true);
			Utility.PressEnterToContinue();
            Environment.Exit(1);
        }
	}
}