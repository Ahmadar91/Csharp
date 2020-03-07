using System;

namespace assignment2
{
	public class Input
	{
		public static int ReadIntegerConsole()
		{
			int input;
			if (int.TryParse(Console.ReadLine(), out input))
				return input;
			else
			{
				Console.WriteLine("Wrong Input. Please try again:");
				return ReadIntegerConsole();
			}
		}


		public static double ReadDoubleConsole()
		{
			double input;
			if (double.TryParse(Console.ReadLine(), out input))
				return input;
			else
			{
				Console.WriteLine("Wrong Input. Please try again:");
				return ReadDoubleConsole();
			}
		}


		public static decimal ReadDecimalConsole()
		{
			decimal input;
			if (decimal.TryParse(Console.ReadLine(), out input))
				return input;
			else
			{
				Console.WriteLine("Wrong Input. Please try again:");
				return ReadDecimalConsole();
			}
		}
	}
}