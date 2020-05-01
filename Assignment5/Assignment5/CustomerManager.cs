using System.Collections.Generic;
using Assignment5.ContactFiles;

namespace Assignment5
{
	public class CustomerManager
	{
		private List<Customer> customers;
		private int id = 0;

		public int Count
		{
			get => customers.Count;
		}

		public int GetNewId
		{

			get => id++;
		}

		public CustomerManager()
		{
			this.customers = new List<Customer>();
		}

		public bool AddCustomer(Contact contact)
		{
			if (contact != null)
			{
				Customer customer = new Customer(contact);
				customers.Add(customer);
				return true;
			}
			return false;
		}

		public bool ChangeCustomer(Customer newCustomer, int index)
		{
			if (CheckIndex(index) && newCustomer != null)
			{
				customers[index] = newCustomer;
				return true;
			}

			return false;
		}

		public bool DeleteCustomer(int index)
		{
			if (CheckIndex(index))
			{
				customers.RemoveAt(index);
				return true;
			}
			return false;
		}

		public bool CheckIndex(int index)
		{
			return index >= 0 && index < customers.Count;
		}

		public bool AddCustomer(Customer customer)
		{
			if (customer != null)
			{
				customers.Add(customer);
				return true;
			}
			return false;
		}

		public Customer GetCustomer(int index)
		{
			 if (CheckIndex(index))
			 {
			 	return customers[index];
			 }
			 return null;
		}

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