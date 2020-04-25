namespace Assignment5.ContactFiles
{
	public class Address
	{
		private string street;
		private string zipCode;
		private string city;
		private Countries country;
		private string strErrMessage;

		public string Street
		{
			get => street;
			set => street = value;
		}

		public string ZipCode
		{
			get => zipCode;
			set => zipCode = value;
		}

		public string City
		{
			get => city;
			set => city = value;
		}

		public Countries Country
		{
			get => country;
			set => country = value;
		}


		public Address():this(string.Empty,string.Empty , "Malmö")
		{

		}

		public Address(string street, string zip, string city): this(street, zip , city, Countries.Sverige)
		{

		}

		public Address(string street, string zip , string city, Countries country)
		{
			this.street = street;
			this.city = city;
			this.country = country;
			this.zipCode = zip;
		}

		public string GetCountryString()
		{
			return country.ToString().Replace("_", " ");
		}
		public override string ToString()
		{
			return $"{0,-25}{1,-8}{2,-10}{3}, street,zipCode, city, GetCountryString()";
		}


		// public bool Validate()
		// {
		// 	 if (country)
		// 	 {
		// 	 	
		// 	 }
		// 	 return true;
		// }


}
}