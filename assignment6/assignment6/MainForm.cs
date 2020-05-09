using System;
using System.Windows.Forms;

namespace assignment6
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			InitilizeGUI();
		}

		private void InitilizeGUI()
		{
			this.Text = "To-Do Manager";
			this.label.Text = string.Empty;
			string[] priority = Enum.GetNames(typeof(PriorityType));
			comboBox.Items.Clear();
			foreach (var item in priority) comboBox.Items.Add(item.Replace("_", " "));
			comboBox.SelectedIndex = (int)PriorityType.Normal;
			priorityToolTip.SetToolTip(comboBox, "Choose a priority for the task");
			toolTip1.SetToolTip(dateTimePicker, "Click to open calendar for date, write in time here");
			dateTimePicker.Format = DateTimePickerFormat.Custom;
			dateTimePicker.CustomFormat = "yyyy-MM-dd    HH:mm";
			openDataFileToolStripMenuItem.Enabled = false;
			saveDataFileToolStripMenuItem.Enabled = false;
		}

		private void timer1_Seconds_Tick(object sender, EventArgs e)
		{
			label.Text = DateTime.Now.ToLongTimeString();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
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

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox ab = new AboutBox();
			ab.ShowDialog();
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InitilizeGUI();
		}
	}
}
