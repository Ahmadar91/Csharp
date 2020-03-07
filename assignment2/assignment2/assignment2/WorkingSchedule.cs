using System;
using System.Text;

namespace assignment2
{
	public class WorkingSchedule
	{
		public void Start()
		{
			WriteProgramInfo();
			ReadInput();
		}

		private void WriteProgramInfo()
		{
			Console.WriteLine("+++++++++++ Working Secluded +++++++++++++++++");
			Console.WriteLine();
			Console.WriteLine($"{"Show a list of the weekends to work:  ",-38} {": 1",10}");
			Console.WriteLine($"{"Show a list of the nights to work:    ",-38} {": 2",10}");
			Console.WriteLine($"{"Return to main menu:      ",-38} {": 0",10}");
			Console.Write("Your Choice: ");
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
							int week = 1;
							int interval = 3;
							Results(week, interval, choice);
							break;
						}
					case 2:
						{
							int week = 6;
							int interval = 5;
							Results(week, interval, choice);
							break;
						}
					// case 0 was left empty to overcome the default since pressing 0 to close the menu will trigger the default case
					case 0:
						{
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

		// For this class i chose a for loop since the week number is given and the interval is also give.
		// so the for loop would be the best choice since i can have full control over the variables in the loop
		private void Results(int week, int interval, int choice)
		{
			StringBuilder str = new StringBuilder();
			for (int i = week; i <= 52; i += interval)
			{
				str.Append($"{"  week " + i,-9}");
				if (i == 31 && choice == 2)
				{
					str.Append("\n");
				}
				else
				{
					if ((i == 16 || i == 34) && choice == 1)
					{
						str.Append("\n");
					}
				}
			}

			Console.WriteLine(str);
			Console.WriteLine("---------------------------------");
			WriteProgramInfo();
		}
	}
}