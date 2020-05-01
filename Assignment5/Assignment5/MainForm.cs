using System;

using System.Windows.Forms;

namespace Assignment5
{
	public partial class MainForm : Form
	{
		private CustomerManager customerManager;
		/// <summary>Initializes a new instance of the <see cref="MainForm" /> class.</summary>
		public MainForm()
		{
			customerManager = new CustomerManager();
			InitializeComponent();
		}

		/// <summary>Handles the Click event of the addBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void addBtn_Click(object sender, EventArgs e)
		{
			ContactForm contactForm = new ContactForm("Add new Customer");
			int index = listBox.SelectedIndex;
			if (contactForm.ShowDialog() == DialogResult.OK)
			{
				if (contactForm.IsCorrect)
				{
					customerManager.AddCustomer(contactForm.ContactData);
					UpdateCustomerList();
				}
					
			}

		}

		/// <summary>Updates the customer list.</summary>
		private void UpdateCustomerList()
		{
			string[] strContacts = customerManager.GetCustomersInfo();
			if (strContacts != null)
			{
				listBox.Items.Clear();
				listBox.Items.AddRange(strContacts);
			}
		}

		/// <summary>Handles the Click event of the changeBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void changeBtn_Click(object sender, EventArgs e)
		{
			int index = listBox.SelectedIndex;
			if (index != -1)
			{
				ContactForm contactForm = new ContactForm("Change new Customer");
				contactForm.ContactData = customerManager.GetCustomer(index).Contact;
				if (contactForm.ShowDialog() == DialogResult.OK)
				{
					if (contactForm.IsCorrect)
					{
						Customer edited = customerManager.GetCustomer(index);
						customerManager.ChangeCustomer(edited, index);
						UpdateCustomerList();
					}
				}
			
			}
			else
			{
				MessageBox.Show("Select an item to change!");
			}
		}

		/// <summary>Handles the Click event of the deleteBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void deleteBtn_Click(object sender, EventArgs e)
		{
			int index = listBox.SelectedIndex;
			if (index != -1)
			{
				listBox.Items.RemoveAt(index);
				customerManager.DeleteCustomer(index);
			}
			else
			{
				MessageBox.Show("Select an item to delete!");
			}
		}

	}
}
