using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace assignment6
{
	public class TaskManager
	{
		private List<Task> taskList;

		/// <summary>Gets the count.</summary>
		/// <value>The count.</value>
		public int Count => taskList.Count;

		/// <summary>Initializes a new instance of the <see cref="TaskManager" /> class.</summary>
		public TaskManager()
		{
			taskList = new List<Task>();
		}

		/// <summary>Adds the specified task.</summary>
		/// <param name="task">The task.</param>
		public void Add(Task task)
		{
			if (task != null)
			{
				taskList.Add(task);
				taskList.Sort((x, y) => x.Date.CompareTo(y.Date));
			}

		}

		/// <summary>Adds the specified date.</summary>
		/// <param name="date">The date.</param>
		/// <param name="priority">The priority.</param>
		/// <param name="description">The description.</param>
		public void Add(DateTime date, PriorityType priority, string description)
		{
			Task task = new Task(date, priority, description);
			taskList.Add(task);
			taskList.Sort((x, y) => x.Date.CompareTo(y.Date));
		}

		/// <summary>Changes the specified new task.</summary>
		/// <param name="newTask">The new task.</param>
		/// <param name="index">The index.</param>
		public void Change(Task newTask, int index)
		{
			if (CheckIndex(index) && newTask != null)
			{
				taskList[index] = newTask;
			}
		}
		/// <summary>Deletes the specified index.</summary>
		/// <param name="index">The index.</param>
		public void Delete(int index)
		{
			if (CheckIndex(index))
			{
				taskList.RemoveAt(index);
			}
		}

		/// <summary>Lists the string array.</summary>
		/// <returns></returns>
		public ListViewItem[] ListStringArray()
		{
			var listViewItems = new List<ListViewItem>();
			foreach (var task in taskList)
			{
				ListViewItem item = new ListViewItem(task.Date.ToShortDateString());
				item.SubItems.Add(task.GetTimeString());
				item.SubItems.Add(task.GetPriorityString());
				item.SubItems.Add(task.Description);
				listViewItems.Add(item);
			}

			return listViewItems.ToArray();
		}

		/// <summary>Checks the index.</summary>
		/// <param name="index">The index.</param>
		/// <returns></returns>
		public bool CheckIndex(int index)
		{
			return index >= 0 && index < taskList.Count;
		}

		/// <summary>Gets the task.</summary>
		/// <param name="index">The index.</param>
		/// <returns></returns>
		public Task GetTask(int index)
		{
			if (CheckIndex(index))
			{
				return taskList[index];
			}
			return null;
		}
	}
}