using Assignment5.ContactFiles;

namespace Assignment5
{
	public class Customer
	{
		private Contact contact;
		private string id;

		/// <summary>Gets or sets the contact.</summary>
		/// <value>The contact.</value>
		public Contact Contact
		{
			get => contact;
			set => contact = value;
		}

		/// <summary>Gets or sets the identifier.</summary>
		/// <value>The identifier.</value>
		public string Id
		{
			get => id;
			set => id = value;
		}

		/// <summary>Initializes a new instance of the <see cref="Customer" /> class.</summary>
		public Customer()
		{
			contact = new Contact();
		}
		/// <summary>Initializes a new instance of the <see cref="Customer" /> class.</summary>
		/// <param name="contact">The contact.</param>
		public Customer(Contact contact)
		{
			this.contact = contact;
		}
		/// <summary>Initializes a new instance of the <see cref="Customer" /> class.</summary>
		/// <param name="other">The other.</param>
		public Customer(Customer other)
		{
			this.contact = other.contact;
			this.id = other.id;
		}
		/// <summary>Initializes a new instance of the <see cref="Customer" /> class.</summary>
		/// <param name="contact">The contact.</param>
		/// <param name="id">The identifier.</param>
		public Customer(Contact contact, string id)
		{
			this.contact = contact;
			this.id = id;
		}


		/// <summary>Converts to string.</summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
		{
			
			return string.Format("{0,-20} {1, -20}", id, contact.ToString());
		}

	}
}