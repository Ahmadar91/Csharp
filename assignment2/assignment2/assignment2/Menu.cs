using System;

namespace assignment2
{
	public class Menu
	{
		public void Start()
		{
			int choice = -1;

			while (choice != 0)
			{
				writeMenuText();
				choice = Input.ReadIntegerConsole();
				switch (choice)
				{
					case 1:
					{
						Console.WriteLine("Whole Number With for");
						WholeNumbersForAdd sumobj = new WholeNumbersForAdd();
						sumobj.Start();
						break;
					}
					case 2:
					{
						FloatNumbersWhileAdd obj = new FloatNumbersWhileAdd();
						obj.Start();
						break;
					}
					case 3:
					{
						CurrencyConverter obj = new CurrencyConverter();
						obj.Start();
						break;
					}
					case 4:
					{
						TemperatureTable temp = new TemperatureTable();
						temp.Start();
						break;
					}
					case 5:
					{
						WorkingSchedule obj = new WorkingSchedule();
							obj.start();
						break;
					}
					default:
					{
						Console.WriteLine("Invalid input Choose a number from the menu");
						break;
					}
				}
			}
		}

		private void writeMenuText()
		{
			Console.WriteLine("---------------------------------");
			Console.WriteLine("MAIN MENU");
			Console.WriteLine("---------------------------------");

			Console.WriteLine("Whole Number With for:                  1");
			Console.WriteLine("Whole Number With while:                2");
			Console.WriteLine("Currency Converter with Do While Loop:  3");
			Console.WriteLine("Temperature Table                       4");
			Console.WriteLine("Work Schedule:                          5");
			Console.WriteLine("Exit The Program                        0");
			Console.WriteLine("---------------------------------");
			Console.Write("Your choice:");
		}
	}
}