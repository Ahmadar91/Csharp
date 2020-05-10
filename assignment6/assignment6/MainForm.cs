using System;
using System.Windows.Forms;

namespace assignment6
{
	public partial class MainForm : Form
	{
		private TaskManager taskManager;
		public MainForm()
		{

			InitializeComponent();
			taskManager = new TaskManager();
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
			dateTimePicker.Value = DateTime.Now;
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

		private void addBtn_Click(object sender, EventArgs e)
		{
			Task newTask = GetTaskFromUserInput();
			if (newTask != null)
			{
				taskManager.Add(newTask);
				UpdateGUI();
			}
		}

		private Task GetTaskFromUserInput()
		{
			if (ReadInput())
			{
				Task task = new Task(dateTimePicker.Value , (PriorityType)comboBox.SelectedIndex, textBox.Text);
				return task;
			}
			return null;
		}

		private bool ReadInput()
		{
			return ReadDate() && ReadDescription();
		}

		private bool ReadDescription()
		{
			if (string.IsNullOrEmpty(textBox.Text))
			{
				MessageBox.Show("Description must not be Null");
				return false;
			}

			return true;
		}

		
		private bool ReadDate()
		{
			if ((dateTimePicker.Value < new DateTime(2000, 01, 01) ||  dateTimePicker.Value >= new DateTime(2222, 01, 01)))
			{
				MessageBox.Show("Wrong date, must be between 2000 - 2222");
				return false;
			}
			return true;
		}

		private void UpdateGUI()
		{
			textBox.Text = string.Empty;
			comboBox.SelectedIndex = (int)PriorityType.Normal;
			dateTimePicker.Value = DateTime.Now;
			string[] strTasks = taskManager.ListStringArray();
			if (strTasks != null)
			{
				listBox.Items.Clear();
				listBox.Items.AddRange(strTasks);
			}
		}

		private void changeBtn_Click(object sender, EventArgs e)
		{
			int index = listBox.SelectedIndex;
			if (index != -1)
			{
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

		private void delBtn_Click(object sender, EventArgs e)
		{
			int index = listBox.SelectedIndex;
			if (index != -1)
			{
				listBox.Items.RemoveAt(index);
				taskManager.Delete(index);
				UpdateGUI();
			}
			else
			{
				MessageBox.Show("Select an item to delete!");
			}
		}

		private void listBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = listBox.SelectedIndex;
			if (index != -1)
			{
				Task task = taskManager.GetTask(index);
				comboBox.SelectedIndex = (int)task.Priority;
				textBox.Text = task.Description;
				dateTimePicker.Value = task.Date;
			}
		
		}
	}
}
