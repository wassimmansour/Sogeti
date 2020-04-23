using BL;
using System;

namespace StringCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			string numbers = "1,3";
			int result = Calculator.Add(numbers);

			Console.WriteLine($"result of adding {numbers} is {result}.");

			Console.ReadKey();
		}
	}
}
