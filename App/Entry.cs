using System;
using ATMConsoleApp.UI;


namespace ATMConsoleApp.App
{
	public class Entry
	{
		static void Main(string[]args)
		{
			AppScreen.Welcome();
			var atmApp = new ATMConsoleApp();
			atmApp.InitializeData();
			atmApp.CheckUserCardNumAndPassword();
            atmApp.Welcome();
            Utility.PressEnterToContinue();
		}
	}
}