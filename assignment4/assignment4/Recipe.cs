

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
				if (string.IsNullOrEmpty(value))
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
				if (string.IsNullOrEmpty(value))
				{
					_name = value;
				}
			}


		}

		public int CurrentNumOfIngredients()
		{
			int count = 0;
			foreach (string ingredient in _ingredientArray)
			{
				if (!string.IsNullOrEmpty(ingredient))
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
				_ingredientArray[i] = String.Empty;
			}
			this._description = "";
			this._name = "";
			this.Category = Category.Vegetarian;
		}

		private int FindVacantPos()
		{
			for (int i = 0; i < _ingredientArray.Length; i++)
			{
				if (!string.IsNullOrEmpty(_ingredientArray[i]))
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

			return string.Format("{0,20} {1,4} {2,-12} {3,-15}", _name, CurrentNumOfIngredients(), this.Category.ToString(),
				descriptionText);
		}
	}

}