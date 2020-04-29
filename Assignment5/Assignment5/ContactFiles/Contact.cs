using System;

namespace Assignment5.ContactFiles
{
	public class Contact
	{
		private Address address;
		private Email email;
		private Phone phone;
		private string fName;
		private string lName;
		public Address Address
		{
			get => address;
			set => address = value;
		}

		public string FullName
		{
			get => fName + lName;
		}
		public Email Email
		{
			get => email;
			set => email = value;
		}

		public Phone Phone
		{
			get => phone;
			set => phone = value;
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
			email = new Email();
			phone = new Phone();
		}

		public Contact(string fName, string lName, Address address , Phone phone, Email email)
		{
			this.fName = fName;
			this.lName = lName;
			this.address = address;
			this.phone = phone;
			this.email = email;

		}

		public override string ToString()
		{
			return string.Format("{0,-20} {1, -20} {2, -20} {3, -20}", FullName, address, phone,email );
		}

	}
}