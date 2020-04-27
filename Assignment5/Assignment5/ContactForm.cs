
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
	}
}
