using System.Threading;

namespace assignment4
{
	public class RecipeManager
	{
		private Recipe[] recipeList;


		/// <summary>Initializes a new instance of the <see cref="RecipeManager" /> class.</summary>
		/// <param name="maxNumOfElements">The maximum number of elements.</param>
		public RecipeManager(int maxNumOfElements)
		{
			this.recipeList = maxNumOfElements > 50 ? new Recipe[50] : new Recipe[maxNumOfElements];
		}


		/// <summary>Finds the vacant position.</summary>
		/// <returns></returns>
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

		/// <summary>Currents the number of items.</summary>
		/// <returns></returns>
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

		/// <summary>Gets the recipe at.</summary>
		/// <param name="index">The index.</param>
		/// <returns></returns>
		public Recipe GetRecipeAt(int index)
		{
			return CheckIndex(index) ? recipeList[index] : null;
		}


		/// <summary>Adds the specified new recipe.</summary>
		/// <param name="newRecipe">The new recipe.</param>
		/// <returns></returns>
		public bool Add(Recipe newRecipe)
		{
			int index = FindVacantPos();
			if (index < 0 || newRecipe == null) return false;
			recipeList[index] = newRecipe;
			return true;
		}


		/// <summary>Adds the specified name.</summary>
		/// <param name="name">The name.</param>
		/// <param name="description">The description.</param>
		/// <param name="category">The category.</param>
		/// <param name="ingredients">The ingredients.</param>
		/// <returns></returns>
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

		/// <summary>Recipes the array.</summary>
		/// <returns></returns>
		public Recipe[] RecipeArray()
		{
			return recipeList;
		}

		/// <summary>Changes the element.</summary>
		/// <param name="index">The index.</param>
		/// <param name="recipe">The recipe.</param>
		/// <returns></returns>
		public bool ChangeElement(int index, Recipe recipe)
		{
			if (!CheckIndex(index)) return false;
			recipeList[index] = recipe;
			return true;
		}


		/// <summary>Deletes the element.</summary>
		/// <param name="index">The index.</param>
		/// <returns></returns>
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


		/// <summary>Deletes all recipes.</summary>
		public void DeleteAllRecipes()
		{
			for (int i = 0; i < recipeList.Length; i++)
			{
				recipeList[i] = null;
			}
		}


		/// <summary>Gets the ingredients.</summary>
		/// <param name="index">The index.</param>
		/// <returns></returns>
		public string[] GetIngredients(int index)
		{
			return recipeList[index].IngredientArray;
		}

		/// <summary>Recipes the list to string.</summary>
		/// <returns></returns>
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


		/// <summary>Checks the index.</summary>
		/// <param name="index">The index.</param>
		/// <returns></returns>
		private bool CheckIndex(int index)
		{
			return index >= 0 && index < recipeList.Length;
		}
	}
}