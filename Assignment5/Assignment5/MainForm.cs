using System;

using System.Windows.Forms;

namespace Assignment5
{
	public partial class MainForm : Form
	{
		private CustomerManager customerManager;
		public MainForm()
		{
			customerManager = new CustomerManager();
			InitializeComponent();
		}

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
			// if (contactForm.IsCorrect)
			// {
			// 	// if (contactForm.ShowDialog() == DialogResult.OK)
			// 	// {
			// 	customerManager.AddCustomer(contactForm.ContactData);
			// 	UpdateCustomerList();
			// 	// }
			// }

		}

		private void UpdateCustomerList()
		{
			string[] strContacts = customerManager.GetCustomersInfo();
			if (strContacts != null)
			{
				listBox.Items.Clear();
				listBox.Items.AddRange(strContacts);
			}
		}

		private void changeBtn_Click(object sender, EventArgs e)
		{
			int index = listBox.SelectedIndex;
			if (index != -1)
			{
				ContactForm contactForm = new ContactForm("Change new Customer");
				contactForm.ContactData = customerManager.GetCustomer(index).Contact;
				if (contactForm.ShowDialog() == DialogResult.OK)
				{
					Customer edited = customerManager.GetCustomer(index);
					customerManager.ChangeCustomer(edited, index);
					UpdateCustomerList();
				}
			
			}
			else
			{
				MessageBox.Show("Select an item to change!");
			}
		}

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
