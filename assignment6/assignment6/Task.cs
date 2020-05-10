using System;

namespace assignment6
{
	public class Task
	{

		private DateTime date;
		private string description;
		private PriorityType priority;

		public DateTime Date
		{
			get => date;
			set => date = value;
		}

		public string Description
		{
			get => description;
			set => description = value;
		}

		public PriorityType Priority
		{
			get => priority;
			set => priority = value;
		}

		public Task(DateTime date, PriorityType priority, string description)
		{
			this.date = date;
			this.priority = priority;
			this.description = description;
		}

		public string GetPriorityString()
		{
			string str = Enum.GetName(typeof(PriorityType), priority);
			if (str.Contains("_"))
			{
				return str.Replace("_", " ");
			}
			return str;
		}


		public string GetTimeString()
		{
			return date.ToShortTimeString();
		}

		public override string ToString()
		{
			return $"{date.ToShortDateString(),-23}" 
			       + $"{GetTimeString(),-10}"
			       + $"{GetPriorityString(),-25}" 
			       + $"{description}";
		}


	}
}