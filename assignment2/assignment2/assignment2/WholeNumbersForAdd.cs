using System;

namespace assignment2
{
	public class WholeNumbersForAdd
	{
		private int _numOfInput;
		private int _sum;

		public void Start()
		{
			WriteProgramInfo();
			ReadInput();
			SumNumbers();
			ShowResults();
		}

		private void ShowResults()
		{
			Console.WriteLine("------------------\n");
			Console.WriteLine("the sum is \t{0}", _sum);
		}

		private void SumNumbers()
		{
			for (int i = 1; i <= _numOfInput; i++)
			{
				Console.Write("Please  give  the value number no " + i + " (whole number): ");
				int num = Input.ReadIntegerConsole();
				_sum += num;
			}
		}

		private void ReadInput()
		{
			Console.Write("Number of whole numbers to sum? ");
			_numOfInput = Input.ReadIntegerConsole();
			Console.WriteLine();
		}

		private void WriteProgramInfo()
		{
			Console.WriteLine("\n\n +++++++++Summation of whole numbers+++++++++");
			Console.WriteLine("              Using a for-statement\n");
			Console.WriteLine();
		}
	}
}