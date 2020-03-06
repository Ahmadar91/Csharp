using System;

namespace assignment2
{
	public class TemperatureTable
	{
		public void Start()
		{
		
			ReadInput();
		}

		private void ReadInput()
		{
			int choice = -1;
			while (choice != 0)
			{
				
				choice = Input.ReadIntegerConsole();
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
						// case 0 was left empty to overcome the default since pressing 0 to close the menu will trigger the default case
						case 0:
						{
							break;
						}
						default:
						{
							Console.Write("Invalid input Choose a number from the menu: ");
							break;
						}
					}
				
			}
		}

		private void WriteProgramInfo()
		{
			Console.WriteLine("\n\n +++++++++Temperature Table+++++++++");
			Console.WriteLine();
			Console.WriteLine($"{"From Celsius to Fahrenheit:",-38} {": 1",10}");
			Console.WriteLine($"{"From Fahrenheit to Celsius:",-38} {": 2",10}");
			Console.WriteLine($"{"return to MainMenu: ",-38} {": 0",10}");
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

				string str = $"{Math.Round(toCelsius)}°C";
				string str2 = $"{Math.Round(index)}°F";
				string con = $"{str2,20}{"=",15}{str,15}";
				Console.WriteLine(con);
				index += 2;
			}

			WriteProgramInfo();
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

				string str = $"{Math.Round(index)}°C";
				string str2 = $"{Math.Round(toFahrenheit)}°F";
				string con = $"{str,20}{"=",15}{str2,15}";
				Console.WriteLine(con);
				index += 2;
			}

			WriteProgramInfo();
		}
	}
}