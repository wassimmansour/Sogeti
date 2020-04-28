using System;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleKeyInfo key = new ConsoleKeyInfo();
			do
			{
				Console.WriteLine("Enter custom substitutions in the format 'number:substitution,number2:substitution2':");
				string substitutions = Console.ReadLine();

				Console.WriteLine("Enter a number:");
				string numbersString = Console.ReadLine();

				int result = 0;
				try
				{
					result = Calculator.Add(delimitersString + "\n" + numbersString);
					Console.WriteLine($"result of adding {numbersString} is {result}.");
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
