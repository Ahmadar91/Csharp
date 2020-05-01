using System;

namespace Assignment5.ContactFiles
{
	public class Phone
	{
		private string home;
		private string work;
		private string other;

		public string Home
		{
			get => home;
			set => home = value;
		}

		public string Work
		{
			get => work;
			set => work = value;
		}

		public string Other
		{
			get => other;
			set => other = value;
		}

		public Phone()
		{
			DefaultValues();
		}

		public Phone(string home, string work)
		{

		}
		public void DefaultValues()
		{
			home = string.Empty;
			work = string.Empty;
			other = string.Empty;
		}
		public string GetToStringItemsHeadings
		{
			get { return string.Format("{0,-20} {1, -20}", "Home Phone", "Work Phone"); }
		}
		public override string ToString()
		{
			return string.Format("{0,-20} {1, -3}", home, work);
		}
	}
}