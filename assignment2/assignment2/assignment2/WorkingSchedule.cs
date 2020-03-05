using System;

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
			Console.WriteLine("Show a list of the weekends to work:       1");
			Console.WriteLine("Show a list of the nights to work:         2");
			Console.WriteLine("Return to main menu:                       0");
			Console.WriteLine("Your Choice");
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
						// default:
						// {
						// 	Console.WriteLine("Invalid input Choose a number from the menu");
						// 	break;
						// }
					}
				}
			}
		}

		private void ShowWeekEnds()
		{
			for (int i = 1; i < 55; i+=3)
			{
				Console.WriteLine("week " + i);
			}

			WriteProgramInfo();
		}

		private void ShowNights()
		{
			for (int i = 6; i < 55; i += 5)
			{
				Console.WriteLine("week " + i);
			}

			WriteProgramInfo();
		}
	}
}