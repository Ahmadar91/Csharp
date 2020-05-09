using System;
using System.Collections.Generic;

namespace assignment6
{
	public class TaskManager
	{
		private List<Task> taskList;

		public int Count => taskList.Count;

		public TaskManager()
		{
			taskList = new List<Task>();
		}

		public void Add(Task task)
		{
			if (task != null)
			{
				taskList.Add(task);
				taskList.Sort((x, y) => x.Date.CompareTo(y.Date));
			}

		}

		public void Add(DateTime date, PriorityType priority, string description)
		{
			Task task = new Task(date, priority, description);
			taskList.Add(task);
			taskList.Sort((x, y) => x.Date.CompareTo(y.Date));
		}

		public void Change(Task newTask, int index)
		{
			if (CheckIndex(index) && newTask != null)
			{
				taskList[index] = newTask;
			}
		}
		public void Delete(int index)
		{
			if (CheckIndex(index))
			{
				taskList.RemoveAt(index);
			}
		}

		public String[] ListStringArray()
		{
			string[] taskArray = new string[Count];
			for (int i = 0; i < Count; i++)
			{
				taskArray[i] = taskList.ToString();
			}

			return taskArray;
		}

		public bool CheckIndex(int index)
		{
			return index >= 0 && index < taskList.Count;
		}

	}
}