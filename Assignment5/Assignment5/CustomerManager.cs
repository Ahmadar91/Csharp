using System.Collections.Generic;
using Assignment5.ContactFiles;

namespace Assignment5
{
	public class CustomerManager
	{
		private List<Customer> customers;
		private int id = 100;

		/// <summary>Gets the count.</summary>
		/// <value>The count.</value>
		public int Count
		{
			get => customers.Count;
		}

		/// <summary>Gets the get new identifier.</summary>
		/// <value>The get new identifier.</value>
		public int GetNewId
		{

			get => id++;
		}

		/// <summary>Initializes a new instance of the <see cref="CustomerManager" /> class.</summary>
		public CustomerManager()
		{
			this.customers = new List<Customer>();
		}

		/// <summary>Adds the customer.</summary>
		/// <param name="contact">The contact.</param>
		/// <returns></returns>
		public bool AddCustomer(Contact contact)
		{
			if (contact != null)
			{
				Customer customer = new Customer(contact, GetNewId.ToString());
				customers.Add(customer);
				return true;
			}
			return false;
		}

		/// <summary>Changes the customer.</summary>
		/// <param name="newCustomer">The new customer.</param>
		/// <param name="index">The index.</param>
		/// <returns></returns>
		public bool ChangeCustomer(Customer newCustomer, int index)
		{
			if (CheckIndex(index) && newCustomer != null)
			{
				customers[index] = newCustomer;
				return true;
			}

			return false;
		}

		/// <summary>Deletes the customer.</summary>
		/// <param name="index">The index.</param>
		/// <returns></returns>
		public bool DeleteCustomer(int index)
		{
			if (CheckIndex(index))
			{
				customers.RemoveAt(index);
				return true;
			}
			return false;
		}

		/// <summary>Checks the index.</summary>
		/// <param name="index">The index.</param>
		/// <returns></returns>
		public bool CheckIndex(int index)
		{
			return index >= 0 && index < customers.Count;
		}

		/// <summary>Adds the customer.</summary>
		/// <param name="customer">The customer.</param>
		/// <returns></returns>
		public bool AddCustomer(Customer customer)
		{
			if (customer != null)
			{
				customers.Add(customer);
				return true;
			}
			return false;
		}

		/// <summary>Gets the customer.</summary>
		/// <param name="index">The index.</param>
		/// <returns></returns>
		public Customer GetCustomer(int index)
		{
			 if (CheckIndex(index))
			 {
			 	return customers[index];
			 }
			 return null;
		}

		/// <summary>Gets the customers information.</summary>
		/// <returns></returns>
		public string[] GetCustomersInfo()
		{
			string[] strInfo = new string[customers.Count];
			int i = 0;
			foreach (Customer contactObj in customers)
			{
				strInfo[i++] = contactObj.ToString();
			}

			return strInfo;
		}
	}
}