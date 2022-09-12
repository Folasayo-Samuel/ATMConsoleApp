using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;


namespace ATMConsoleApp.UI;

public class Validator
{
	public static T Convert<T>(string prompt)
	{
		var valid = false;
		string userInput;
		
		while(!valid)
		{
			userInput = Utility.GetUserInput(prompt);
			
			try
			{
			  var converter =  TypeDescriptor.GetConverter(typeof(T));
			  if(converter != null)
					return (T)converter.ConvertFromString(userInput);
			   else
					return default;


			}
			catch (System.Exception)
			{

				Utility.PrintMessage("Invalid input. Try again", false);
			}
		}
		return default;

	}
} 