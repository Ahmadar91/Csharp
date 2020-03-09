using System;
using System.Runtime.InteropServices;

namespace assignment3
{
	public class BMICalculator
	{
		private string _name = "No name";
		private double _height = 0;
		private double _weight = 0;
		private UnitTypes _unit;


		public string GetName()
		{
			return this._name;
		}
		public void SetName(string value)
		{
			if (!string.IsNullOrEmpty(value))
			{
				this._name = value;
			}
			
		}


		public double GetHeight()
		{
			return this._height;
		}
		public void SetHeight(double value)
		{
			if (value > 0)
			{
				this._height = value;
			}

		}


		public double GetWeight()
		{
			return this._height;
		}
		public void SetWeight(double value)
		{
			if (value > 0)
			{
				this._weight = value;
			}

		}


		public UnitTypes GetUnitType()
		{
			return this._unit;
		}

		public void SetUnitType(UnitTypes value)
		{
			this._unit = value;
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
			double bmi;
			if ((_unit == UnitTypes.Metric) )
			{
				bmi = _weight / Math.Pow(_height, 2);
			}
			else
				 bmi = (703.0 *_weight) / Math.Pow(_height, 2);

			return bmi;
		}
	}
}