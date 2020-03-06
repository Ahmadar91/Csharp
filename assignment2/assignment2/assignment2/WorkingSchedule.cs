using System;
using System.Text;

namespace assignment2
{
	public class WorkingSchedule
	{
		public void start()
		{
			WriteProgramInfo();
			ReadInput();
		}

		private void WriteProgramInfo()
		{
			Console.WriteLine("+++++++++++ Working Secluded +++++++++++++++++");
			Console.WriteLine();
			Console.WriteLine($"{"Show a list of the weekends to work:  ",-38} {": 1",10:C}");
			Console.WriteLine($"{"Show a list of the nights to work:    ",-38} {": 2",10:C}");
			Console.WriteLine($"{"Return to main menu:      ",-38} {": 0",10:C}");
			Console.Write("Your Choice: ");
		}


		private void ReadInput()
		{

			int choice = -1;
			while (choice != 0)
			{
				choice = Input.ReadIntegerConsole();

				{
					switch (choice)
					{
						case 1:
						{
							ShowWeekEnds();
							break;
						}
						case 2:
						{
							ShowNights();
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
		}

		private void ShowWeekEnds()
		{
			StringBuilder str = new StringBuilder();

			for (int i = 1; i <= 52; i+=3)
			{
				
				str.Append($"{"  week " + i,-9}");
				if (i == 16 || i == 34)
				{
					str.Append("\n");
				}
			}
			


			Console.WriteLine(str);
			Console.WriteLine("---------------------------------");
			WriteProgramInfo();
		}

		private void ShowNights()
		{
			StringBuilder str = new StringBuilder();
			for (int i = 6; i <= 52; i += 5)
			{

				str.Append($"{"  week " + i,-9}");
				if (i == 31)
				{
					str.Append("\n");
				}
			}
			Console.WriteLine(str);
			Console.WriteLine("---------------------------------");
			WriteProgramInfo();
		}
	}
}