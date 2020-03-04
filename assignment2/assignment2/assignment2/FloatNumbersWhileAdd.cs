using System;

namespace assignment2
{

	public class FloatNumbersWhileAdd
	{
		private double sum;

		public void Start()
		{
			WriteProgramInfo();
			ReadInputAndSumNumbers();
			ShowResults();
		}

		private void WriteProgramInfo()
		{
			Console.WriteLine("\n\n +++++++++Summation of real numbers+++++++++");
			Console.WriteLine("              Using a while loop\n");
			Console.WriteLine();
		}

		private void ReadInputAndSumNumbers()
		{
			bool done = false;
			while (!done)
			{
				double num = ReadInput();
				if (Math.Round(num, 7) == 0.0)
				{
					done = true;
				}
				else
				{
					sum += num;
				}
			}
		}

		private double ReadInput()
		{

			Console.Write("Write an amount to sum or zero to finish: ");

			double num = Input.ReadDoubleConsole();
			return num;
		}

		private void ShowResults()
		{
			Console.WriteLine("------------------\n");
			Console.WriteLine("the sum is \t{0}", sum);
		}
	}
}