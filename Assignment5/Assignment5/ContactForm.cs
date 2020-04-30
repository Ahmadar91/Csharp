
using System;
using System.Windows.Forms;
using Assignment5.ContactFiles;
using Microsoft.SqlServer.Server;

namespace Assignment5
{
	public partial class ContactForm : Form
	{
		private Contact contact = new Contact();
		private bool closeForm;
		private bool isCorrectInfo = false;
		private bool isCanceled = false;
		public bool IsCorrectInfo { get => isCorrectInfo; set => isCorrectInfo = value; }
		public bool IsCanceled { get => isCanceled; set => isCanceled = value; }
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
			countryCombo.SelectedIndex = (int) Countries.Sverige;
			closeForm = true;

		}

		public Contact ContactData
		{
			get => contact;
			set
			{
				if (value != null)
				{
					contact = value;
					UpdateGUI();
				}
			}
		}

		private void UpdateGUI()
		{
			firstNameTxt.Text = contact.FName;
			lastNameTxt.Text = contact.LName;
			homeTxt.Text = contact.Phone.Home;
			workTxt.Text = contact.Phone.Work;
			emailTxt.Text = contact.Email.Personal;
			streetTxt.Text = contact.Address.Street;
			cityTxt.Text = contact.Address.City;
			zipTxt.Text = contact.Address.ZipCode;
			countryCombo.SelectedIndex = (int)contact.Address.Country;
		}

	

	

		private void SetToDefult()
		{
			firstNameTxt.Text = "";
			lastNameTxt.Text = "";
			homeTxt.Text = "";
			workTxt.Text = "";
			emailTxt.Text = "";
			streetTxt.Text = "";
			cityTxt.Text = "";
			zipTxt.Text = "";
			countryCombo.SelectedIndex = 0;
		}

		private bool ReadInput()
		{
			
			return ReadName() && ReadPhone() && ReadEmails() && ReadAddress();
		}

		private bool ReadAddress()
		{

			contact.Address.City = cityTxt.Text;
			contact.Address.Country = (Countries)countryCombo.SelectedIndex;
			contact.Address.Street = streetTxt.Text;
			contact.Address.ZipCode = zipTxt.Text;
			return true;
		}

		public bool ReadEmails()
		{

			
			if (!string.IsNullOrEmpty(emailTxt.Text))
			{
				contact.Email.Personal = emailTxt.Text;
				contact.Email.Work = emailTxt.Text;
				return true;
			}

			return false;
		}

		

		public bool ReadPhone()
		{
			
			if (!string.IsNullOrEmpty(homeTxt.Text) || !string.IsNullOrEmpty(workTxt.Text))
			{
				contact.Phone.Home = homeTxt.Text;
				contact.Phone.Work = workTxt.Text;
				return true;
			}

			return false;
		}

		private bool ReadName()
		{
			if (!string.IsNullOrEmpty(firstNameTxt.Text) && !string.IsNullOrEmpty(lastNameTxt.Text))
			{
				contact.FName = firstNameTxt.Text;
				contact.LName = lastNameTxt.Text;
				return true;
			}
			return false;

		}

		public override string ToString()
		{
			return contact.ToString();
		}

		
		private void cancel_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
		
			//if ((MessageBox.Show("Are you sure you want to add this customer", "Add Customer Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
			//	MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
			//{
			//	isCanceled = false;
				if (ReadInput() && contact.Address.Validate())
				{
					
				// MessageBox.Show("dadadadadad");
				// MessageBox.Show(string.Format("{0} {1}\n{2} {3}", contact.Address.ToString(), contact.Email.ToString(), contact.Phone.ToString()));
				//IsCorrectInfo = true;
				// SetToDefult();

			}
				else
				{
					MessageBox.Show("Invalided Input! insert Data to Procced or Cancel!");
					IsCorrectInfo = false;
				}

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
		}
	
	}
}


// const string message =
// "Are you sure that you would like to close the form?";
// const string caption = "Form Closing";
// var result = MessageBox.Show(message, caption,
// MessageBoxButtons.YesNo,
// MessageBoxIcon.Question);
//
// // If the no button was pressed ...
// if (result == DialogResult.No)
// {
// // cancel the closure of the form.
// e.Cancel = true;
// }