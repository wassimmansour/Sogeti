using BL;
using System;

namespace StringCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleKeyInfo key = new ConsoleKeyInfo();
			do
			{
				Console.WriteLine("Enter delimiters:");
				string delimitersString = Console.ReadLine();

				Console.WriteLine("Enter numbers string:");
				string numbersString = Console.ReadLine();
				
				try
				{
					result = Calculator.Add(delimitersString + "\n" + numbersString);
					Console.WriteLine($"result of adding {numbersString} is {result}.");
				}
				catch(Exception ex)
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
