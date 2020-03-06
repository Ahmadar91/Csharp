using System;

namespace assignment2
{
	public class CurrencyConverter
	{
		private decimal _sum;
		private string _currency;
		private decimal _total;
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
			_currency = Console.ReadLine();
			Console.WriteLine("Exchange rate: ");
			decimal rate = Input.ReadDecimalConsole();
			_total = _sum * rate;

		}

		private void WriteProgramInfo()
		{
			Console.WriteLine("\n\n +++++++++Currency Converter+++++++++");

			Console.WriteLine();
		}

		private void ReadInputAndSumNumbers()
		{
			bool done = false;
			do
			{
				decimal num = ReadInput();
				if (Math.Round(num, 7) == (decimal) 0.0)
				{
					done = true;
				}
				else
				{
					_sum += num;
				}
			} while (!done);
		}

		private decimal ReadInput()
		{

			Console.Write("Write an amount to sum or zero to finish: ");

			decimal num = Input.ReadDecimalConsole();
			return num;
		}

		private void ShowResults()
		{
			Console.WriteLine("------------------\n");
			Console.WriteLine("the sum is of  " +  " " + _sum +" "+ _currency + " is " + _total + " Kr");
		}
	}
}
