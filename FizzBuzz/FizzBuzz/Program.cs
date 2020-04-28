using BL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleKeyInfo key;
			do
			{
				Console.WriteLine("Enter substitutions in the format 'number1:substitution1,number2:substitution2':");
				string substitutionsInput = Console.ReadLine();

				Console.WriteLine("Enter number:");
				string numberInput = Console.ReadLine();
				int.TryParse(numberInput, out int number);

				try
				{
					string result = SimpleGame.Play(number, substitutionsInput);
					Console.WriteLine($"Number {number} matches {result}.");
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}

				Console.WriteLine("Press enter to repeat. or q to quit.");

				key = Console.ReadKey();
			}
			while (key.KeyChar != 'q');
		}
	}
}
