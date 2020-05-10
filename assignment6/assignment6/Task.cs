using System;

namespace assignment6
{
	public class Task
	{

		private DateTime date;
		private string description;
		private PriorityType priority;

		/// <summary>Gets or sets the date.</summary>
		/// <value>The date.</value>
		public DateTime Date
		{
			get => date;
			set => date = value;
		}

		/// <summary>Gets or sets the description.</summary>
		/// <value>The description.</value>
		public string Description
		{
			get => description;
			set => description = value;
		}

		/// <summary>Gets or sets the priority.</summary>
		/// <value>The priority.</value>
		public PriorityType Priority
		{
			get => priority;
			set => priority = value;
		}

		/// <summary>Initializes a new instance of the <see cref="Task" /> class.</summary>
		/// <param name="date">The date.</param>
		/// <param name="priority">The priority.</param>
		/// <param name="description">The description.</param>
		public Task(DateTime date, PriorityType priority, string description)
		{
			this.date = date;
			this.priority = priority;
			this.description = description;
		}

		/// <summary>Gets the priority string.</summary>
		/// <returns></returns>
		public string GetPriorityString()
		{
			string str = Enum.GetName(typeof(PriorityType), priority);
			if (str.Contains("_"))
			{
				return str.Replace("_", " ");
			}
			return str;
		}


		/// <summary>Gets the time string.</summary>
		/// <returns></returns>
		public string GetTimeString()
		{
			return date.ToShortTimeString();
		}

		/// <summary>Converts to string.</summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
		{
			return $"{date.ToShortDateString(),-23}"
				   + $"{GetTimeString(),-10}"
				   + $"{GetPriorityString(),-25}"
				   + $"{description}";
		}


	}
}