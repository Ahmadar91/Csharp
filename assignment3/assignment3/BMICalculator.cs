using System;
using System.Runtime.InteropServices;

namespace assignment3
{
	public class BMICalculator
	{
		private string name = "No name";
		private double height = 0;
		private double weight = 0;
		private UnitTypes unit;


		public string GetName()
		{
			return this.name;
		}
		public void SetName(string value)
		{
			if (!string.IsNullOrEmpty(value))
			{
				this.name = value;
			}
			
		}


		public double GetHeight()
		{
			return this.height;
		}
		public void SetHeight(double value)
		{
			if (value > 0)
			{
				this.height = value;
			}

		}


		public double GetWeight()
		{
			return this.height;
		}
		public void SetWeight(double value)
		{
			if (value > 0)
			{
				this.weight = value;
			}

		}


		public UnitTypes GetUnitType()
		{
			return this.unit;
		}

		public void SetUnitType(UnitTypes value)
		{
			this.unit = value;
		}

		public string BmiWeightCategory()
		{
			double bmi = CalculateBmi();
			string outPut = string.Empty;
			if (bmi > 40)
				outPut = "OverWeight (Obesity Class III )";
			else if (bmi < 40 && bmi >= 35)
				outPut = "OverWeight (Obesity Class II )";
			else if (bmi < 35 && bmi >= 30)
				outPut = "OverWeight (Obesity Class I )";
			else if (bmi < 30 && bmi >= 25)
				outPut = "OverWeight (Pre-Obesity)";
			else if (bmi < 25 && bmi >= 18.5)
				outPut = "Normal Weight";
			else if (bmi < 18.5)
				outPut = "Under Weight";

			return outPut;
		}

		public double CalculateBmi()
		{
			double BMI;
			if ((unit == UnitTypes.Metric) )
			{
				BMI = weight / Math.Pow(height, 2);
			}
			else
				 BMI = (703.0 *weight) / Math.Pow(height, 2);

			return BMI;
		}
	}
}