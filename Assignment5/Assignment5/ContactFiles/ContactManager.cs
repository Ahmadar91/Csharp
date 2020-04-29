using System.Collections.Generic;

namespace Assignment5.ContactFiles
{
	public class ContactManager
	{
		private List<Contact> contactsRegistry;

		public ContactManager()
		{
			contactsRegistry = new List<Contact>();
		}


		public Contact GetContact(int index)
		{
			if ((index < 0) || index >= contactsRegistry.Count)
			{
				return null;
			}

			Contact origObj = contactsRegistry[index];
			Contact copyObj = new Contact(origObj);

			return copyObj;
		}

		public int Count()
		{
			return contactsRegistry.Count;
		}


		public bool AddContact(string firstName, string lastName, Address addr)
		{
			Contact con = new Contact();
			con.FName = firstName;
			con.LName = lastName;
			con.Address = addr;
			int index = FindVacantPos();
			if (index < 0) return false;
			contactsRegistry[index] = con;
			return true;
		}
		public bool AddContact(Contact contact)
		{
			contactsRegistry.Add(contact);
			return true;
		}

		public bool ChangeContact(Contact contact, int index)
		{
			if (!CheckIndex(index)) return false;
			contactsRegistry[index] = contact;
			return true;
		}


		public bool DeleteContact(int index)
		{
			bool bok = false;
			if (CheckIndex(index))
			{
				for (int i = index; i < contactsRegistry.Count - 1; i++)
				{
					contactsRegistry[i] = contactsRegistry[i + 1];
				}

				bok = true;
			}


			return bok;
		}

		private bool CheckIndex(int index)
		{
			return index >= 0 && index < contactsRegistry.Count;
		}

		/// <summary>Finds the vacant position.</summary>
		/// <returns></returns>
		private int FindVacantPos()
		{
			for (int i = 0; i < contactsRegistry.Count; i++)
			{
				if (contactsRegistry[i] != null)
				{
					return i;
				}
			}

			return -1;
		}

		public void TestValues()
		{
			AddContact(new Contact("Apu", "simpson", new Address("Simpsson north Avenue", "12 456", "Malmo")));
			AddContact(new Contact("Nisse", "LundStrum", new Address("Lundgatan", "11 445", "Kalmar")));
		}

		public string[] GetContactsInfo()
		{
			string[] strInfo = new string[contactsRegistry.Count];
			int i = 0;
			foreach (Contact contactObj in contactsRegistry)
			{
				strInfo[i++] = contactObj.ToString();
			}

			return strInfo;
		}


	}
}