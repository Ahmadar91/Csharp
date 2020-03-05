using System;

namespace assignment2
{
	public class TemperatureTable
	{
		public void Start()
		{
			WriteProgramInfo();
			ReadInput();
		}

		private void ReadInput()
		{
			int choice = Input.ReadIntegerConsole();
			switch (choice)
			{
				case 1:
					{
						ShowCelsiusToFahrenheit();
						break;
					}
				case 2:
					{
						ShowFahrenheitToCelsius();
						break;
					}
			}
		}

		private void WriteProgramInfo()
		{
			Console.WriteLine("\n\n +++++++++Temperature Table+++++++++");
			Console.WriteLine();
			Console.WriteLine("From Celsius to Fahrenheit:          1");
			Console.WriteLine("From Fahrenheit to Celsius:          2");
			Console.Write("your Choice: ");
		}


		private void ShowFahrenheitToCelsius()
		{
			Console.WriteLine("------------------------------");
			Console.WriteLine("Fahrenheit To Celsius");
			Console.WriteLine("------------------------------");
			double index = 0.00;
			for (int i = 0; i <= 100; i += 2)
			{
				double toCelsius = 5.0 / 9.0 * (index - 32);
				string str = string.Format("{0}°C", Math.Round(toCelsius));
				string str2 = string.Format("{0}°F", Math.Round(index));
				Console.WriteLine(str2 + "          =                 " + str);

				index += 2;
			}
		}

		private void ShowCelsiusToFahrenheit()
		{
			Console.WriteLine("------------------------------");
			Console.WriteLine("Celsius To Fahrenheit");
			Console.WriteLine("------------------------------");
			double index = 0.00;
			for (int i = 0; i <= 100; i += 2)
			{
				double toFahrenheit = 9.0 / 5.0 * (index + 32.0);
				string str = string.Format("{0}°C", Math.Round(toFahrenheit));
				string str2 = string.Format("{0}°F", Math.Round(index));
				Console.WriteLine(str + "          =                 " + str2);
				index += 2;
			}
		}
	}
}