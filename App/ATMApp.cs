using System;
using ATMApp.UI;

namespace ATMConsoleApp
 {
 	class ATMApp
	{
		static void Main(string[]args)
		{
			AppScreen.Welcome();
			var cardNumber = Validator.Convert<long>("your card number");
			Console.WriteLine($"Your card number is {cardNumber}");

            Utility.PressEnterToContinue();
        }
	}
 }