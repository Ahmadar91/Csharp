using Assignment5.ContactFiles;

namespace Assignment5
{
	public class Customer
	{
		private Contact contact;
		private string id;

		public Contact Contact
		{
			get => contact;
			set => contact = value;
		}

		public string Id
		{
			get => id;
			set => id = value;
		}

		public Customer()
		{
			contact = new Contact();
		}	
		public Customer(Contact contact)
		{
			this.contact = contact;
		}
		public Customer(Customer other)
		{
			this.contact = other.contact;
			this.id = other.id;
		}
		public Customer(Contact contact, string id)
		{
			this.contact = contact;
			this.id = id;
		}


		public override string ToString()
		{
			
			return string.Format("{0,-20} {1, -20}", id, contact.ToString());
		}

	}
}