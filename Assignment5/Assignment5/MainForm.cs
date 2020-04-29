
using System;
using System.Windows.Forms;
using Assignment5.ContactFiles;

namespace Assignment5
{
	public partial class MainForm : Form
	{
		private ContactManager contactManager;
		public MainForm()
		{
			InitializeComponent();
			contactManager = new ContactManager();
			InitializeGUI();
		}
		public MainForm(string title)
		{
			InitializeComponent();

			InitializeGUI();
		}


		private void InitializeGUI()
		{
			recordsLabel.Text = "";
			countryCombo.DataSource = Enum.GetNames(typeof(Countries));
			countryCombo.SelectedIndex = (int)Countries.Sverige;
			contactManager.TestValues();
			UpdateGUI();

		}


		private void UpdateGUI()
		{
			string[] strContacts = contactManager.GetContactsInfo();
			if (strContacts != null)
			{
				listBox.Items.Clear();
				listBox.Items.AddRange(strContacts);
				recordsLabel.Text = listBox.Items.Count.ToString();
			}
		}



		private Address ReadAddress()
		{
			return new Address(streetTxt.Text, zipTxt.Text, cityTxt.Text, (Countries)countryCombo.SelectedIndex);
		}



		private bool ReadInput()
		{
			Contact contact = new Contact();
			contact.FName = firstNameTxt.Text;
			contact.LName = lastNameTxt.Text;
			Address addr = ReadAddress();
			if (addr.Validate())
			{
				contact.Address = addr;
			}
			else
			{
				string errMessage = "First name, last name and city are required input! \nplease try again!";
				MessageBox.Show(errMessage);
			}
			
			bool ok = contact.Validate();
			if (ok)
			{
				contactManager.AddContact(contact);
			}
			else
			{
				string errMessage = "First name, last name and city are required input! \nplease try again!";
				MessageBox.Show(errMessage);
			}

			return ok;
		}


		private bool ReadName(ref Contact contact)
		{
			if (!string.IsNullOrEmpty(firstNameTxt.ToString()) && !string.IsNullOrEmpty(lastNameTxt.ToString()))
			{
				// contact.FName = firstNameTxt.ToString();
				// contact.LName = lastNameTxt.ToString();
				return true;
			}
			return false;

		}

		public override string ToString()
		{
			return "";
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			if (ReadInput())
			{
				UpdateGUI();
			}
		}

		private void listBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateContactInfoFromRegistry();
		}

		private void UpdateContactInfoFromRegistry()
		{
			int index = listBox.SelectedIndex;
			if (index < 0)
			{
				return;
			}

			Contact contact = contactManager.GetContact(index);
			countryCombo.SelectedIndex = (int)contact.Address.Country;
			firstNameTxt.Text = contact.FName;
			lastNameTxt.Text = contact.LName;
			streetTxt.Text = contact.Address.Street;
			cityTxt.Text = contact.Address.City;
			zipTxt.Text = contact.Address.ZipCode;
		}

		private void changeBtn_Click(object sender, EventArgs e)
		{
			int index = listBox.SelectedIndex;
			if (index < 0)
			{
				return;
			}
			Contact contact = contactManager.GetContact(index);
			contact.FName = firstNameTxt.Text;
			contact.LName = lastNameTxt.Text;
			Address addr = ReadAddress();
			contact.Address = addr;

			bool ok = contact.Validate();
			if (ok)
			{
				contactManager.ChangeContact(contact, index);
				UpdateGUI();
			}
			else
			{
				string errMessage = "First name, last name and city are required input! \nplease try again!";
				MessageBox.Show(errMessage);
			}



		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			contactManager.DeleteContact(listBox.SelectedIndex);
			UpdateGUI();
		}
	}
}
