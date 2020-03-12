using System.Diagnostics;

namespace assignment3
{
	public class BMRCalculator
	{
		private int _age = 0;
		private Genders _gennder;
		private ActivityLevels _activity;
		private double _height = 0;
		private double _weight = 0;
		private double _factor = 0;

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
		public void SetAge(int value)
		{
			this._age = value;
		}

		public int GetAge()
		{
			return this._age;
		}
		public void SetFactor(double value)
		{
			this._factor = value;
		}

		public double GetFactor()
		{
			return this._factor;
		}

		public void SetGender(Genders value)
		{
			this._gennder = value;
		}

		public Genders GetGender()
		{
			return this._gennder;
		}


		public void SetActivity(ActivityLevels value)
		{
			this._activity = value;
		}

		public ActivityLevels GetActivity()
		{
			return this._activity;
		}

		public double CalculateBMR()
		{
			double BMR = 10 * _weight + 6.25 * _height - 5 * GetAge();
			if (GetGender() == Genders.Female)
			{
				return BMR - 161;
			}
			else
				return BMR + 5;
		}


		public void Factor()
		{

			switch (_activity)
			{
				case ActivityLevels.Sedentary:
					{
						SetFactor(1.2);
						break;
					}

				case ActivityLevels.LightlyActive:
					{
						SetFactor(1.375);
						break;
					}
				case ActivityLevels.ModeratelyActive:
					{
						SetFactor(1.550);
						break;
					}
				case ActivityLevels.VeryActive:
					{
						SetFactor(1.725);
						break;
					}
				case ActivityLevels.ExtraActive:
					{
						SetFactor(1.9);
						break;
					}
			}
		}

		public void Results()
		{
			double bmr = CalculateBMR();
		}
	}
}