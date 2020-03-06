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
			int choice = -1;
			bool done = false;
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
						// default:
						// {
						// 	Console.Write("Invalid input Choose a number from the menu: ");
						// 	break;
						// }
					}
				
			}
		}

		private void WriteProgramInfo()
		{
			Console.WriteLine("\n\n +++++++++Temperature Table+++++++++");
			Console.WriteLine();
			Console.WriteLine($"{"From Celsius to Fahrenheit:",-38} {": 1",10:C}");
			Console.WriteLine($"{"From Fahrenheit to Celsius:",-38} {": 2",10:C}");
			Console.WriteLine($"{"return to MainMenu: ",-38} {": 0",10:C}");
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
				string con = String.Format("{0,20}{1,15}{2,15}", str2, "=", str);
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

				string str = string.Format("{0}°C", Math.Round(index));
				string str2 = string.Format("{0}°F", Math.Round(toFahrenheit));
				string con = String.Format("{0,20}{1,15}{2,15}", str, "=", str2);
				Console.WriteLine(con);
				index += 2;
			}

			WriteProgramInfo();
		}
	}
}