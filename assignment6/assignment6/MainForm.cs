using System;
using System.Windows.Forms;

namespace assignment6
{
	public partial class MainForm : Form
	{
		private TaskManager taskManager;

		/// <summary>Initializes a new instance of the <see cref="MainForm" /> class.</summary>
		public MainForm()
		{
			InitializeComponent();
			taskManager = new TaskManager();
			InitilizeGUI();
		}

		/// <summary>Initilizes the GUI.</summary>
		private void InitilizeGUI()
		{
			this.Text = "To-Do Manager";
			this.label.Text = string.Empty;
			string[] priority = Enum.GetNames(typeof(PriorityType));
			comboBox.Items.Clear();
			foreach (var item in priority) comboBox.Items.Add(item.Replace("_", " "));
			comboBox.SelectedIndex = (int)PriorityType.Normal;
			dateTimePicker.Value = DateTime.Now;
			priorityToolTip.SetToolTip(comboBox, "Choose a priority for the task");
			toolTip1.SetToolTip(dateTimePicker, "Click to open calendar for date, write in time here");
			dateTimePicker.Format = DateTimePickerFormat.Custom;
			dateTimePicker.CustomFormat = "yyyy-MM-dd    HH:mm";
			openDataFileToolStripMenuItem.Enabled = false;
			saveDataFileToolStripMenuItem.Enabled = false;
		}

		/// <summary>Handles the Tick event of the timer1_Seconds control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void timer1_Seconds_Tick(object sender, EventArgs e)
		{
			label.Text = DateTime.Now.ToLongTimeString();
		}

		/// <summary>Handles the FormClosing event of the MainForm control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FormClosingEventArgs" /> instance containing the event data.</param>
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

		/// <summary>Handles the Click event of the exitToolStripMenuItem control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>Handles the Click event of the aboutToolStripMenuItem control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox ab = new AboutBox();
			ab.ShowDialog();
		}

		/// <summary>Handles the Click event of the newToolStripMenuItem control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InitilizeGUI();
		}

		/// <summary>Handles the Click event of the addBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void addBtn_Click(object sender, EventArgs e)
		{
			Task newTask = GetTaskFromUserInput();
			if (newTask != null)
			{
				taskManager.Add(newTask);
				UpdateGUI();
			}
		}

		/// <summary>Gets the task from user input.</summary>
		/// <returns></returns>
		private Task GetTaskFromUserInput()
		{
			if (ReadInput())
			{
				Task task = new Task(dateTimePicker.Value, (PriorityType)comboBox.SelectedIndex, textBox.Text);
				return task;
			}

			return null;
		}

		/// <summary>Reads the input.</summary>
		/// <returns></returns>
		private bool ReadInput()
		{
			return ReadDate() && ReadDescription();
		}

		/// <summary>Reads the description.</summary>
		/// <returns></returns>
		private bool ReadDescription()
		{
			if (string.IsNullOrEmpty(textBox.Text))
			{
				MessageBox.Show("Description must not be Null");
				return false;
			}

			return true;
		}


		/// <summary>Reads the date.</summary>
		/// <returns></returns>
		private bool ReadDate()
		{
			if ((dateTimePicker.Value < new DateTime(2000, 01, 01) ||
				 dateTimePicker.Value >= new DateTime(2222, 01, 01)))
			{
				MessageBox.Show("Wrong date, must be between 2000 - 2222");
				return false;
			}

			return true;
		}

		/// <summary>Updates the GUI.</summary>
		private void UpdateGUI()
		{
			textBox.Text = string.Empty;
			comboBox.SelectedIndex = (int)PriorityType.Normal;
			dateTimePicker.Value = DateTime.Now;
			listView.Items.Clear();
			listView.Items.AddRange(taskManager.ListStringArray());
		}

		/// <summary>Handles the Click event of the changeBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void changeBtn_Click(object sender, EventArgs e)
		{
			if (listView.Items.Count > 0)
			{
				if (listView.FocusedItem != null)
				{
					int index = listView.FocusedItem.Index;

					if (ReadInput())
					{
						Task task = taskManager.GetTask(index);
						task.Date = dateTimePicker.Value;
						task.Priority = (PriorityType)comboBox.SelectedIndex;
						task.Description = textBox.Text;
						taskManager.Change(task, index);
						UpdateGUI();
					}
				}
				else
				{
					MessageBox.Show("Select an item to change!");
				}
			}
			else
			{
				MessageBox.Show("No items in the List view");
			}
		}

		/// <summary>Handles the Click event of the delBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void delBtn_Click(object sender, EventArgs e)
		{
			if (listView.Items.Count > 0)
			{
				if (listView.FocusedItem != null)
				{
					int index = listView.FocusedItem.Index;

					if (this.DialogResult != DialogResult.OK)
					{
						const string message =
							"Are you sure that you would like to delete this item?";
						const string caption = "Form Closing";
						var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
							MessageBoxIcon.Question);
						// If the no button was pressed ...
						if (result == DialogResult.Yes)
						{
							listView.Items.RemoveAt(index);
							taskManager.Delete(index);
							UpdateGUI();
						}
					}
				}
				else
				{
					MessageBox.Show("Select an item to delete!");
				}
			}
			else
			{
				MessageBox.Show("No items in the List view");
			}
		}


		/// <summary>Handles the SelectedIndexChanged event of the listView control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void listView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView.Items.Count > 0 && listView.FocusedItem != null)
			{
				int index = listView.FocusedItem.Index;
				Task task = taskManager.GetTask(index);
				if (task != null)
				{
					comboBox.SelectedIndex = (int)task.Priority;
					textBox.Text = task.Description;
					dateTimePicker.Value = task.Date;
				}
			}
		}
	}
}