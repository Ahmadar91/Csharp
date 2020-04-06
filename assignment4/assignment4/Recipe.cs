

using System;

namespace assignment4
{
	public class Recipe
	{
		private string description;
		private string[] ingredientArray;
		private string name;

		public Category Category { get; set; }

		public Recipe(int maxNumOfIngredients)
		{
			this.ingredientArray = maxNumOfIngredients > 50 ? new string[50] : new string[maxNumOfIngredients];
			DefaultValues();
		}
		public string Description
		{
			get => description;
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					description = value;
				}
			}

		}

		public string[] IngredientArray
		{
			get => ingredientArray;
			set => ingredientArray = value;
		}

		public string Name
		{
			get => name;
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					name = value;
				}
			}


		}

		public int MaxNumOfIngredients => ingredientArray.Length;


		public int CurrentNumOfIngredients()
		{
			int count = 0;
			for (int i = 0; i < ingredientArray.Length; i++)
			{

				if (!string.IsNullOrEmpty(ingredientArray[i]))
				{
					count++;
				}
			}

			return count;
		}




		public bool AddIngredient(string value)
		{
			int index = FindVacantPos();
			if (index < 0) return false;
			ingredientArray[index] = value;
			return true;
		}

		public bool ChangeIngredientAt(int index, string value)
		{
			if (!CheckIndex(index)) return false;
			ingredientArray[index] = value;
			return true;
		}

		private bool CheckIndex(int index)
		{
			return index >= 0 && index < ingredientArray.Length;

		}


		public void DefaultValues()
		{
			for (int i = 0; i < ingredientArray.Length; i++)
			{
				ingredientArray[i] = string.Empty;
			}
			description = string.Empty;
			name = string.Empty;
			Category = Category.Vegetarian;
		}

		private int FindVacantPos()
		{
			for (int i = 0; i < ingredientArray.Length; i++)
			{
				if (string.IsNullOrEmpty(ingredientArray[i]))
				{
					return i;
				}
			}
			return -1;
		}


		public override string ToString()
		{
			int chars = Math.Min(description.Length, 15);
			string descriptionText = description.Substring(0, chars);

			if (string.IsNullOrEmpty(descriptionText))
				descriptionText = " No Description!";

			string output = string.Format("{0,2} {1,35} {2,35} {3,40}", name, CurrentNumOfIngredients(), Category.ToString(),
				descriptionText);
			return output;
		}

	}

}