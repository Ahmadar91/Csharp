
using System;
using System.Windows.Forms;
using Assignment5.ContactFiles;

namespace Assignment5
{
	public partial class ContactForm : Form
	{
		private Contact contact = new Contact();
		private bool isCorrect;

		/// <summary>Gets or sets a value indicating whether this instance is correct.</summary>
		/// <value>
		///   <c>true</c> if this instance is correct; otherwise, <c>false</c>.</value>
		public bool IsCorrect
		{
			get => isCorrect;
			set => isCorrect = value;
		}

		/// <summary>Initializes a new instance of the <see cref="ContactForm" /> class.</summary>
		public ContactForm()
		{
			InitializeComponent();

			InitializeGUI();
		}
		/// <summary>Initializes a new instance of the <see cref="ContactForm" /> class.</summary>
		/// <param name="title">The title.</param>
		public ContactForm(string title)
		{
			InitializeComponent();
			InitializeGUI();
		}


		/// <summary>Initializes the GUI.</summary>
		private void InitializeGUI()
		{

			countryCombo.DataSource = Enum.GetNames(typeof(Countries));
			countryCombo.SelectedIndex = (int) Countries.Sverige;


		}

		/// <summary>Gets or sets the contact data.</summary>
		/// <value>The contact data.</value>
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

		/// <summary>Updates the GUI.</summary>
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


		/// <summary>Reads the input.</summary>
		/// <returns></returns>
		private bool ReadInput()
		{
			
			return ReadName() && ReadPhone() && ReadEmails() && ReadAddress();
		}

		/// <summary>Reads the address.</summary>
		/// <returns></returns>
		private bool ReadAddress()
		{

			contact.Address.City = cityTxt.Text;
			contact.Address.Country = (Countries)countryCombo.SelectedIndex;
			contact.Address.Street = streetTxt.Text;
			contact.Address.ZipCode = zipTxt.Text;
			return true;
		}

		/// <summary>Reads the emails.</summary>
		/// <returns></returns>
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



		/// <summary>Reads the phone.</summary>
		/// <returns></returns>
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

		/// <summary>Reads the name.</summary>
		/// <returns></returns>
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

		/// <summary>Converts to string.</summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
		{
			return contact.ToString();
		}


		/// <summary>Handles the 1 event of the cancel_Click control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void cancel_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}




		/// <summary>Handles the Click event of the okButton control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void okButton_Click(object sender, EventArgs e)
		{
			
			if (ReadInput() && contact.Address.Validate())
			{
				isCorrect = true;
			}
			else
			{
				isCorrect = false;
				MessageBox.Show("Invalided Input! insert Correct Data or Zip code must be in numbers!");
				
			}
		}

		/// <summary>Handles the FormClosing event of the ContactForm control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FormClosingEventArgs" /> instance containing the event data.</param>
		private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.DialogResult != DialogResult.OK)
			{
				const string message =
					"Are you sure that you would like to close the form?";
				const string caption = "Form Closing";
				var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				// If the no button was pressed ...
				if (result == DialogResult.No)
				{
					// cancel the closure of the form.
					e.Cancel = true;
				}
			}

		}
	}
}
