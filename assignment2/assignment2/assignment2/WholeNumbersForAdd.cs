using System;

namespace assignment2
{
	public class WholeNumbersForAdd
	{
		private int numOfInput;
		private int sum;
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
			Console.WriteLine("the sum is \t{0}", sum);
		}

		private void SumNumbers()
		{
		
			int num = 1;
			for (int i = 1; i <= numOfInput; i++)
			{
				Console.WriteLine("Please  give  the value number no "+ i + " (whole number): ");
				num = int.Parse(Console.ReadLine());
				sum += num;
			}
		}

		private void ReadInput()
		{
			Console.Write("Number of whole numbers to sum? ");
			numOfInput = int.Parse(Console.ReadLine());
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