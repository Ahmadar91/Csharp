namespace assignment4
{
	public class RecipeManager
	{
		private Recipe[] _recipeList;


		public RecipeManager(int maxNumOfElements)
		{
			this._recipeList = maxNumOfElements > 50 ? new Recipe[50] : new Recipe[maxNumOfElements];
		}


		private int FindVacantPos()
		{
			for (int i = 0; i < _recipeList.Length; i++)
			{
				if (_recipeList[i] == null)
				{
					return i;
				}
			}

			return -1;
		}

		public int CurrentNumberOfItems()
		{
			int count = 0;
			for (int i = 0; i < _recipeList.Length; i++)
			{
				if (_recipeList[i] != null)
				{
					count++;
				}
			}

			return count;
		}
		public Recipe GetRecipeAt(int index)
		{
			return CheckIndex(index) ? _recipeList[index] : null;
		}


		public bool Add(Recipe newRecipe)
		{
			int index = FindVacantPos();
			if (index < 0 || newRecipe == null) return false;
			_recipeList[index] = newRecipe;
			return true;
		}



		public bool Add(string name, Category category, string[] ingredients)
		{
			bool bok = false;
			int index = FindVacantPos();
			if (index > 0)
			{
				Recipe recipe = new Recipe(ingredients.Length);
				recipe.Name = name;
				recipe.IngredientArray = ingredients;
				recipe.Category = category;

				_recipeList[index] = recipe;
				bok = true;

			}

			return bok;
		}

		public bool ChangeElement(int index, Recipe recipe)
		{
			if (!CheckIndex(index)) return false;
			_recipeList[index] = recipe;
			return true;
		}


		public bool ChangeElement(int index)
		{
			bool bok = false;
			if (CheckIndex(index))
			{
				_recipeList[index] = null;
				bok = true;
			}

			return bok;
		}


		public string[] GetIngredients(int index)
		{
			return _recipeList[index].IngredientArray;
		}

		public string[] RecipeListToString()
		{

			string[] str = new string[CurrentNumberOfItems()];


			for (int i = 0; i < _recipeList.Length; i++)
			{
				if (_recipeList[i] == null)
				{
					break;
				}


				str[i] = _recipeList[i].ToString();
			}
			return str;
		}





		private bool CheckIndex(int index)
		{
			return index >= 0 && index < _recipeList.Length;

		}




	}
}