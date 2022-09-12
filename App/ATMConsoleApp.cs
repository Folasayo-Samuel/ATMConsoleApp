using System;
using ATMConsoleApp.UI;
using ATMConsoleApp.Domain.Entities;
using ATMConsoleApp.Domain.Interfaces;

namespace ATMConsoleApp.App
 {
 	public class ATMConsoleApp : IUserLogin
	{
		private List<UserAccount> userAccountList;
		private UserAccount selectedAccount; 
		
		public void InitializeData()
		{
			userAccountList = new List<UserAccount>
			{
				new UserAccount{Id = 1, FullName = "Folasayo Samuel Olayemi", AccountNumber = 1234567890, CardNumber = 12345678, CardPin = 12345679, AccountBalance = 100000.00m, IsLocked = false},

				new UserAccount{Id = 2, FullName = "Folasayo Adigun", AccountNumber = 1234567899, CardNumber = 12345688, CardPin = 1211, AccountBalance = 500000.00m, IsLocked = false},

				new UserAccount{Id = 3, FullName = "Ozigi Samuel Ozovehe", AccountNumber = 1234567800, CardNumber = 12345611, CardPin = 1222, AccountBalance = 700000.00m, IsLocked = true},
		};
		}
		public void CheckUserCardNumAndPassword()
		{
			var isCorrectLogin = false;
			while(isCorrectLogin == false)
			{
				var inputAccount = AppScreen.UserLoginForm();
				AppScreen.LoginProgress();
				foreach (UserAccount account in userAccountList)
				{
					selectedAccount = account;
					if(inputAccount.CardNumber.Equals(selectedAccount.CardNumber))
					{
						selectedAccount.TotalLogin++;
						
						if(inputAccount.CardPin.Equals(selectedAccount.CardPin))
						{
							selectedAccount = account;
							
							if(selectedAccount.IsLocked || selectedAccount.TotalLogin > 3)
							{
								// Print a lock message
								AppScreen.PrintLockScreen();
							} else
							{
								selectedAccount.TotalLogin = 0;
								isCorrectLogin = true;
								break;
							}
						}
					}
					
					if(isCorrectLogin == false)
			{
				Utility.PrintMessage("\n Invalid card number or PIN.", false);
				selectedAccount.IsLocked = selectedAccount.TotalLogin == 3;
				if(selectedAccount.IsLocked)
					AppScreen.PrintLockScreen();
			}
			Console.Clear();
				}
			}
			
			

		}
		
	 public void Welcome()
	 {
			Console.WriteLine($"Welcome back, {selectedAccount.FullName}");
		}
	
	}
 }