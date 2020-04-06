

using System;

namespace assignment4
{
	public class Recipe
	{
		private string _description;
		private string[] _ingredientArray;
		private string _name;

		public Category Category { get; set; }

		public Recipe(int maxNumOfIngredients)
		{
			this._ingredientArray = maxNumOfIngredients > 50 ? new string[50] : new string[maxNumOfIngredients];
			DefaultValues();
		}
		public string Description
		{
			get => _description;
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					_description = value;
				}
			}

		}

		public string[] IngredientArray
		{
			get => _ingredientArray;
			set => _ingredientArray = value;
		}

		public string Name
		{
			get => _name;
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					_name = value;
				}
			}


		}

		public int MaxNumOfIngredients => _ingredientArray.Length;


		public int CurrentNumOfIngredients()
		{
			int count = 0;
			for (int i = 0; i < _ingredientArray.Length; i++)
			{

				if (!string.IsNullOrEmpty(_ingredientArray[i]))
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
			_ingredientArray[index] = value;
			return true;
		}

		public bool ChangeIngredientAt(int index, string value)
		{
			if (!CheckIndex(index)) return false;
			_ingredientArray[index] = value;
			return true;
		}

		private bool CheckIndex(int index)
		{
			return index >= 0 && index < _ingredientArray.Length;

		}


		public void DefaultValues()
		{
			for (int i = 0; i < _ingredientArray.Length; i++)
			{
				_ingredientArray[i] = string.Empty;
			}
			_description = string.Empty;
			_name = string.Empty;
			Category = Category.Vegetarian;
		}

		private int FindVacantPos()
		{
			for (int i = 0; i < _ingredientArray.Length; i++)
			{
				if (string.IsNullOrEmpty(_ingredientArray[i]))
				{
					return i;
				}
			}
			return -1;
		}


		public override string ToString()
		{
			int chars = Math.Min(_description.Length, 15);
			string descriptionText = _description.Substring(0, chars);

			if (string.IsNullOrEmpty(descriptionText))
				descriptionText = " No Description!";

			string output = string.Format("{0,2} {1,35} {2,35} {3,40}", _name, CurrentNumOfIngredients(), Category.ToString(),
				descriptionText);
			return output;
		}

	}

}