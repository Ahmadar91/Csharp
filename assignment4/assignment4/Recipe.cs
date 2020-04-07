using System;

namespace assignment4
{
	public class Recipe
	{
		private string description;
		private string[] ingredientArray;
		private string name;

		/// <summary>Gets or sets the category.</summary>
		/// <value>The category.</value>
		public Category Category { get; set; }

		/// <summary>Initializes a new instance of the <see cref="Recipe" /> class.</summary>
		/// <param name="maxNumOfIngredients">The maximum number of ingredients.</param>
		public Recipe(int maxNumOfIngredients)
		{
			this.ingredientArray = maxNumOfIngredients > 50 ? new string[50] : new string[maxNumOfIngredients];
			DefaultValues();
		}

		/// <summary>Gets or sets the description.</summary>
		/// <value>The description.</value>
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

		/// <summary>Gets or sets the ingredient array.</summary>
		/// <value>The ingredient array.</value>
		public string[] IngredientArray
		{
			get => ingredientArray;
			set => ingredientArray = value;
		}

		/// <summary>Gets or sets the name.</summary>
		/// <value>The name.</value>
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

		/// <summary>Gets the maximum number of ingredients.</summary>
		/// <value>The maximum number of ingredients.</value>
		public int MaxNumOfIngredients => ingredientArray.Length;


		/// <summary>Currents the number of ingredients.</summary>
		/// <returns></returns>
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


		/// <summary>Adds the ingredient.</summary>
		/// <param name="value">The value.</param>
		/// <returns></returns>
		public bool AddIngredient(string value)
		{
			int index = FindVacantPos();
			if (index < 0) return false;
			ingredientArray[index] = value;
			return true;
		}

		/// <summary>Changes the ingredient at.</summary>
		/// <param name="index">The index.</param>
		/// <param name="value">The value.</param>
		/// <returns></returns>
		public bool ChangeIngredientAt(int index, string value)
		{
			if (!CheckIndex(index)) return false;
			ingredientArray[index] = value;
			return true;
		}

		/// <summary>Checks the index.</summary>
		/// <param name="index">The index.</param>
		/// <returns></returns>
		private bool CheckIndex(int index)
		{
			return index >= 0 && index < ingredientArray.Length;
		}


		/// <summary>Defaults the values.</summary>
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

		/// <summary>Finds the vacant position.</summary>
		/// <returns></returns>
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


		/// <summary>Converts to string.</summary>
		/// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public override string ToString()
		{
			int chars = Math.Min(description.Length, 15);
			string descriptionText = description.Substring(0, chars);

			if (string.IsNullOrEmpty(descriptionText))
				descriptionText = " No Description!";

			string output = string.Format("{0,2} {1,35} {2,35} {3,40}", name, CurrentNumOfIngredients(),
				Category.ToString(),
				descriptionText);
			return output;
		}
	}
}