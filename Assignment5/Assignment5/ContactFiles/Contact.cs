using System;

namespace Assignment5.ContactFiles
{
	public class Contact
	{
		private Address address;

		private string fName = string.Empty;
		private string lName = string.Empty;
		public Address Address
		{
			get => address;
			set => address = value;
		}

		public string FullName
		{
			get => fName + lName;
		}



		public string FName
		{
			get => fName;
			set => fName = value;
		}

		public string LName
		{
			get => lName;
			set => lName = value;
		}


		public Contact()
		{
			address = new Address();
		}

		public Contact(string fName, string lName, Address address)
		{
			this.fName = fName;
			this.lName = lName;
			this.address = address;

		}


		public Contact(Contact other)
		{
			this.fName = other.fName;
			this.lName = other.lName;
			this.Address = other.address;
		}

		public bool Validate()
		{
			return true;
		}
		public override string ToString()
		{
			string str = string.Format("{0,-20} {1, -20} {2, -20} {3, -20}", FullName, address.ToString());
			return str;
		}
	}
}