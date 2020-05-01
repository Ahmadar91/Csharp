using System;

namespace Assignment5.ContactFiles
{
	public class Phone
	{
		private string home;
		private string work;
		private string other;

		/// <summary>Gets or sets the home.</summary>
		/// <value>The home.</value>
		public string Home
		{
			get => home;
			set => home = value;
		}

		/// <summary>Gets or sets the work.</summary>
		/// <value>The work.</value>
		public string Work
		{
			get => work;
			set => work = value;
		}

		/// <summary>Gets or sets the other.</summary>
		/// <value>The other.</value>
		public string Other
		{
			get => other;
			set => other = value;
		}

		/// <summary>Initializes a new instance of the <see cref="Phone" /> class.</summary>
		public Phone()
		{
			DefaultValues();
		}

		/// <summary>Initializes a new instance of the <see cref="Phone" /> class.</summary>
		/// <param name="home">The home.</param>
		/// <param name="work">The work.</param>
		public Phone(string home, string work)
		{

		}
		/// <summary>Defaults the values.</summary>
		public void DefaultValues()
		{
			home = string.Empty;
			work = string.Empty;
			other = string.Empty;
		}
		/// <summary>Gets the get to string items headings.</summary>
		/// <value>The get to string items headings.</value>
		public string GetToStringItemsHeadings
		{
			get { return string.Format("{0,-20} {1, -20}", "Home Phone", "Work Phone"); }
		}
		/// <summary>Converts to string.</summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
		{
			return string.Format("{0,-20} {1, -3}", home, work);
		}
	}
}