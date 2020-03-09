namespace assignment3
{
	public class FuelConsumption
	{
		private int _currentReading;
		private int _previousReading;
		private int _fuelAmount;
		private double _fuelPrice;

	

		public void SetCurrentReading(int value)
		{
			if (value > 0)
			{
				this._currentReading = value;
			}
		}

		public int GetCurrentReading()
		{
			return this._currentReading;
		}

		public void SetPreviousReading(int value)
		{
			if (value > 0)
			{
				this._previousReading = value;
			}
		}

		public int GetPreviousReading()
		{
			return this._previousReading;
		}

		public void SetFuelAmount(int value)
		{
			if (value > 0)
			{
				this._fuelAmount = value;
			}
		}

		public int GetFuelAmount()
		{
			return this._fuelAmount;
		}

		public void SetFuelPrice(double value)
		{
			if (value > 0)
			{
				this._fuelPrice = value;
			}
		}

		public double GetFuelPrice()
		{
			return this._fuelPrice;
		}

		private double GetKm()
		{
			return this._currentReading - this._previousReading;
		}

		public double LitPerKm()
		{
			return this._fuelAmount / GetKm();
			
		}

		public double KmPerLit()
		{
			return GetKm() / this._fuelAmount;
		}
		public double LitPerMetric()
		{
			const double kmToMileFactor = 0.621371192;
			return LitPerKm() / kmToMileFactor;
		}
		public double LitPerSwe()
		{
			return LitPerKm() * 10;
		}

		public double CostPerKm()
		{
			return LitPerKm() * this._fuelPrice;
		}
	}
}