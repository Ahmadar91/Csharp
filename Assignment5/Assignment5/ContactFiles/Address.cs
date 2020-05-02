using System;

namespace Assignment5.ContactFiles
{
	public class Address
	{
		private string street;
		private string zipCode;
		private string city;
		private Countries country;
		private string strErrMessage;

		/// <summary>Gets or sets the street.</summary>
		/// <value>The street.</value>
		public string Street
		{
			get => street;
			set => street = value;
		}

		/// <summary>Gets or sets the zip code.</summary>
		/// <value>The zip code.</value>
		public string ZipCode
		{
			get => zipCode;
			set => zipCode = value;
		}

		/// <summary>Gets or sets the city.</summary>
		/// <value>The city.</value>
		public string City
		{
			get => city;
			set => city = value;
		}

		/// <summary>Gets or sets the country.</summary>
		/// <value>The country.</value>
		public Countries Country
		{
			get => country;
			set => country = value;
		}


		/// <summary>Initializes a new instance of the <see cref="Address" /> class.</summary>
		public Address():this(string.Empty,string.Empty , "Malmö")
		{

		}

		/// <summary>Initializes a new instance of the <see cref="Address" /> class.</summary>
		/// <param name="street">The street.</param>
		/// <param name="zip">The zip.</param>
		/// <param name="city">The city.</param>
		public Address(string street, string zip, string city): this(street, zip , city, Countries.Sverige)
		{

		}

		/// <summary>Initializes a new instance of the <see cref="Address" /> class.</summary>
		/// <param name="street">The street.</param>
		/// <param name="zip">The zip.</param>
		/// <param name="city">The city.</param>
		/// <param name="country">The country.</param>
		public Address(string street, string zip , string city, Countries country)
		{
			this.street = street;
			this.city = city;
			this.country = country;
			this.zipCode = zip;
		}

		/// <summary>Gets the country string.</summary>
		/// <returns></returns>
		private string GetCountryString()
		{
			string str = Enum.GetName(typeof(Countries), country);
			if (str.Contains("_"))
			{
				return str.Replace("_", " ");
			}
			return str;
		}
		/// <summary>Converts to string.</summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
		{
			return $"{street,5}{zipCode,6}{city,7}{GetCountryString(),8}";

		}


		/// <summary>Validates this instance.</summary>
		/// <returns></returns>
		public bool Validate()
		{
			if (!string.IsNullOrEmpty(city) && city.Length < 1)
			{
				return false;
			}
			if (!string.IsNullOrEmpty(zipCode))
			{
				return int.TryParse(zipCode, out int x);
			}
			return true;
		}


}
}