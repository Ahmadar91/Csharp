using System.Threading;

namespace assignment4
{
	public class RecipeManager
	{
		private Recipe[] recipeList;


		public RecipeManager(int maxNumOfElements)
		{
			this.recipeList = maxNumOfElements > 50 ? new Recipe[50] : new Recipe[maxNumOfElements];
		}


		private int FindVacantPos()
		{
			for (int i = 0; i < recipeList.Length; i++)
			{
				if (recipeList[i] == null)
				{
					return i;
				}
			}

			return -1;
		}

		public int CurrentNumberOfItems()
		{
			int count = 0;
			for (int i = 0; i < recipeList.Length; i++)
			{
				if (recipeList[i] != null)
				{
					count++;
				}
			}

			return count;
		}
		public Recipe GetRecipeAt(int index)
		{
			return CheckIndex(index) ? recipeList[index] : null;
		}


		public bool Add(Recipe newRecipe)
		{
			int index = FindVacantPos();
			if (index < 0 || newRecipe == null) return false;
			recipeList[index] = newRecipe;
			return true;
		}



		public bool Add(string name, string description, Category category, string[] ingredients)
		{
			bool bok = false;
			int index = FindVacantPos();
			if (index > 0)
			{
				Recipe recipe = new Recipe(ingredients.Length);
				recipe.Name = name;
				recipe.Description = description;
				recipe.IngredientArray = ingredients;
				recipe.Category = category;

				recipeList[index] = recipe;
				bok = true;

			}

			return bok;
		}

		public Recipe[] RecipeArray()
		{
			return recipeList;
		}

		public bool ChangeElement(int index, Recipe recipe)
		{
			if (!CheckIndex(index)) return false;
			recipeList[index] = recipe;
			return true;
		}


		public bool DeleteElement(int index)
		{
			bool bok = false;
			if (CheckIndex(index))
			{
				for (int i = index; i < recipeList.Length - 1; i++)
				{
					recipeList[i] = recipeList[i + 1];
				}
				bok = true;
			}



			return bok;
		}


		public string[] GetIngredients(int index)
		{
			return recipeList[index].IngredientArray;
		}

		public string[] RecipeListToString()
		{

			string[] str = new string[CurrentNumberOfItems()];


			for (int i = 0; i < recipeList.Length; i++)
			{
				if (recipeList[i] != null)
				{
					str[i] = recipeList[i].ToString();
				}

			}
			return str;
		}





		private bool CheckIndex(int index)
		{
			return index >= 0 && index < recipeList.Length;

		}




	}
}