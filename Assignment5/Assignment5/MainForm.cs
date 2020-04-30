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
			contactForm.ShowDialog();
			int index = listBox.SelectedIndex;
			if (index != -1)
			{
				contactForm.ContactData = customerManager.GetCustomer(index).Contact;
				if (contactForm.ShowDialog() == DialogResult.OK)
				{
					customerManager.AddCustomer(contactForm.ContactData);
					UpdateCustomerList();
				}
			}
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
			if (index != -1)   // Validate index
			{
				ContactForm contactForm = new ContactForm("Change new Customer");
				contactForm.ContactData = customerManager.GetCustomer(index).Contact;
				contactForm.ShowDialog();
				if (contactForm.ShowDialog() == DialogResult.OK)
				{
					listBox.Items.RemoveAt(index);
					customerManager.DeleteCustomer(index);
					customerManager.ChangeCustomer(new Customer(contactForm.ContactData), index);
					UpdateCustomerList();
				}
				contactForm.ShowDialog();
			}
			else
			{
				MessageBox.Show("Something is wrong. You may select an item to change!");
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
				MessageBox.Show("You must select an item to delete!");
			}
		}

		private void listBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
