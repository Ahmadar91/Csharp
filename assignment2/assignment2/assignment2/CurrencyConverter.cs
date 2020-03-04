using System;

namespace assignment2
{
	public class CurrencyConverter
	{
		private decimal sum;

		public void Start()
		{
			WriteProgramInfo();
			ReadInputAndSumNumbers();
			ExchangeRate();
			ShowResults();
		}

		private void ExchangeRate()
		{
			Console.Write("Name of the foreign currency: ");
			string str = Console.ReadLine();
			switch (str)
			{
				case "USA":
				{
					Console.WriteLine("Exchange rate: 9.14");
					sum = sum * (decimal)9.14;
					break;
				}
			}

		}

		private void WriteProgramInfo()
		{
			Console.WriteLine("\n\n +++++++++Currency Converter+++++++++");
	
			Console.WriteLine();
		}

		private void ReadInputAndSumNumbers()
		{
			bool done = false;
			while (!done)
			{
				decimal num = ReadInput();
				if (Math.Round(num, 7) == (decimal) 0.0)
				{
					done = true;
				}
				else
				{
					sum += num;
				}
			}
		}

		private decimal ReadInput()
		{

			Console.Write("Write an amount to add to total: ");

			decimal num = Input.ReadDecimalConsole();
			return num;
		}

		private void ShowResults()
		{
			Console.WriteLine("------------------\n");
			Console.WriteLine("the sum is: " + sum + "Kr");
		}
	}
}
