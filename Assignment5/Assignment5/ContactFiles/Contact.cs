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
		/// <summary>Gets or sets the address.</summary>
		/// <value>The address.</value>
		public Address Address
		{
			get => address;
			set => address = value;
		}

		/// <summary>Gets the full name.</summary>
		/// <value>The full name.</value>
		public string FullName
		{
			get => fName + " "+ lName;
		}
		/// <summary>Gets or sets the email.</summary>
		/// <value>The email.</value>
		public Email Email
		{
			get => email;
			set => email = value;
		}

		/// <summary>Gets or sets the phone.</summary>
		/// <value>The phone.</value>
		public Phone Phone
		{
			get => phone;
			set => phone = value;
		}

		/// <summary>Gets or sets the name of the f.</summary>
		/// <value>The name of the f.</value>
		public string FName
		{
			get => fName;
			set => fName = value;
		}

		/// <summary>Gets or sets the name of the l.</summary>
		/// <value>The name of the l.</value>
		public string LName
		{
			get => lName;
			set => lName = value;
		}


		/// <summary>Initializes a new instance of the <see cref="Contact" /> class.</summary>
		public Contact()
		{
			address = new Address();
			email = new Email();
			phone = new Phone();
		}

		/// <summary>Initializes a new instance of the <see cref="Contact" /> class.</summary>
		/// <param name="fName">Name of the f.</param>
		/// <param name="lName">Name of the l.</param>
		/// <param name="address">The address.</param>
		/// <param name="phone">The phone.</param>
		/// <param name="email">The email.</param>
		public Contact(string fName, string lName, Address address , Phone phone, Email email)
		{
			this.fName = fName;
			this.lName = lName;
			this.address = address;
			this.phone = phone;
			this.email = email;

		}

		/// <summary>Converts to string.</summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
		{
			return $"{FullName,-18} {address.ToString(),-38} {phone.ToString(),-25} {email.ToString(),-20}";
		}

	}
}