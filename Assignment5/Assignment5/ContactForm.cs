
using System;
using System.Windows.Forms;
using Assignment5.ContactFiles;

namespace Assignment5
{
	public partial class ContactForm : Form
	{
		private Contact contact = new Contact();
		private bool closeForm;
		public ContactForm()
		{
			InitializeComponent();

			InitializeGUI();
		}	
		public ContactForm(string title)
		{
			InitializeComponent();

			InitializeGUI();
		}


		private void InitializeGUI()
		{

			countryCombo.DataSource = Enum.GetNames(typeof(Countries));
			closeForm = true;

		}

		public Contact ContactData
		{
			get => contact;
			set
			{
				if (value !=null)
				{
					contact = value;
					UpdateGUI();
				}
			}
		}

		private void UpdateGUI()
		{
			throw new NotImplementedException();
		}

		private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			const string message =
				"Are you sure that you would like to close the form?";
			const string caption = "Form Closing";
			var result = MessageBox.Show(message, caption,
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			// If the no button was pressed ...
			if (result == DialogResult.No)
			{
				// cancel the closure of the form.
				e.Cancel = true;
			}
			// if (closeForm)
			// 	e.Cancel = false;
			// else
			// 	e.Cancel = true;
		}

		private void cancel_Click(object sender, EventArgs e)
		{
			
				this.Close();
			
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			if (ReadInput())
			{
				contact.Address = ReadAddress();
				contact.Email = ReadEmails();
				contact.Phone = ReadPhone();
			}

		}


		private Address ReadAddress()
		{
			Address addr = new Address();

			addr.City = cityTxt.ToString();
			addr.Country = (Countries) countryCombo.SelectedIndex;
			addr.Street = streetTxt.ToString();
			addr.ZipCode = zipTxt.ToString();
			return addr;
		}

		public Email ReadEmails()
		{

			Email email = new Email();
			email.Personal = emailTxt.ToString();
			email.Work = emailTxt.ToString();
			return email;
		}

		private bool ReadInput()
		{
			if (ReadName() && ReadAddress().Validate() && !ReadEmails().Equals(null) && !ReadPhone().Equals(null))
			{
				
				return true;
			}
			return false;
		}

		public Phone ReadPhone()
		{
			Phone phone = new Phone();
			phone.Home = homeTxt.ToString();
			phone.Work = workTxt.ToString();
			return phone;
		}

		private bool ReadName()
		{
			if (!string.IsNullOrEmpty(firstNameTxt.ToString()) && !string.IsNullOrEmpty(lastNameTxt.ToString()))
			{
				contact.FName = firstNameTxt.ToString();
				contact.LName = lastNameTxt.ToString();
				return true;
			}
			return false;

		}

		public override string ToString()
		{
			return "";
		}
	}
}
