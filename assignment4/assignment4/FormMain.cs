using System;
using System.Windows.Forms;

namespace assignment4
{
	/// <summary>
	/// To update the ingredients of a recipe click on the recipe click add ingredient then edit or delete or
	/// add new ingredient after clicking the ok button
	/// click on the edit to update the view(the list box of recipes) 
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	public partial class FormMain : Form
	{
		private const int numOfIngredients = 20;
		private const int maxNumOfElements = 50;
		RecipeManager recipeMngr;
		private Recipe currRecipe;

		/// <summary>Initializes a new instance of the <see cref="FormMain" /> class.</summary>
		public FormMain()
		{
			InitializeComponent();
			recipeMngr = new RecipeManager(maxNumOfElements);
			InitializeRecipe();

			InitializeGUI();
		}

		/// <summary>Initializes the recipe.</summary>
		private void InitializeRecipe()
		{
			currRecipe = new Recipe(numOfIngredients);
		}

		/// <summary>Initializes the GUI.</summary>
		private void InitializeGUI()
		{
			CategoryCombo.Items.Add("Meat");
			CategoryCombo.Items.Add("Vegetarian");
			CategoryCombo.Items.Add("Fish");
			CategoryCombo.Items.Add("SeaFood");
			listBox.Text = "";
			CategoryCombo.SelectedIndex = 1;
		}


		/// <summary>Handles the Click event of the AddIngredientsButton control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void AddIngredientsButton_Click(object sender, EventArgs e)
		{
			FormIngredients dlg = new FormIngredients(currRecipe);
			DialogResult dlgResult = dlg.ShowDialog();

			if (dlgResult == DialogResult.OK)
			{
				if (currRecipe.CurrentNumOfIngredients() <= 0)
				{
					MessageBox.Show("No Ingriedients specified!");
					if (!CheckInput())
					{
						MessageBox.Show("No Recipe specified!");
						return;
					}

					recipeMngr.Add(currRecipe);
					UpdateGUI();
				}
			}
		}


		/// <summary>Handles the Click event of the AddRecipeBox control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void AddRecipeBox_Click(object sender, EventArgs e)
		{
			if (!CheckInput())
			{
				MessageBox.Show("No Recipe specified!");
				return;
			}


			currRecipe.Category = (Category)CategoryCombo.SelectedIndex;
			currRecipe.Name = RecipeNameText.Text.Trim();
			currRecipe.Description = textBox.Text.Trim();
			for (int j = 0; j < recipeMngr.RecipeArray().Length; j++)
			{
				if (currRecipe.Equals(recipeMngr.RecipeArray()[j]))
				{
					MessageBox.Show("Recipe Already Exists");
					return;
				}
			}

			recipeMngr.Add(currRecipe);
			UpdateGUI();
			InitializeRecipe();
		}


		/// <summary>Checks the input.</summary>
		/// <returns></returns>
		private bool CheckInput()
		{
			return ReadName() && ReadDescription();
		}

		/// <summary>Reads the description.</summary>
		/// <returns></returns>
		private bool ReadDescription()
		{
			if (!string.IsNullOrEmpty(RecipeNameText.Text))
			{
				return true;
			}

			return false;
		}

		/// <summary>Reads the name.</summary>
		/// <returns></returns>
		private bool ReadName()
		{
			if (!string.IsNullOrEmpty(textBox.Text))
			{
				return true;
			}

			return false;
		}

		/// <summary>Updates the GUI.</summary>
		public void UpdateGUI()
		{
			string[] recipeListStrings = recipeMngr.RecipeListToString();
			listBox.Items.Clear();
			RecipeNameText.Clear();
			textBox.Clear();
			listBox.Items.AddRange(recipeListStrings);
		}

		/// <summary>Handles the Click event of the DelButton control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void DelButton_Click(object sender, EventArgs e)
		{
			listBox.Items.Add("clicked");
			recipeMngr.DeleteElement(listBox.SelectedIndex);
			listBox.ClearSelected();
			UpdateGUI();
		}

		/// <summary>Handles the Click event of the EditButton control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void EditButton_Click(object sender, EventArgs e)
		{
			if (listBox.SelectedIndex >= 0 && listBox.SelectedIndex < recipeMngr.CurrentNumberOfItems())
			{
				currRecipe.Category = (Category)CategoryCombo.SelectedIndex;
				currRecipe.Name = RecipeNameText.Text.Trim();
				currRecipe.Description = textBox.Text.Trim();
				recipeMngr.ChangeElement(listBox.SelectedIndex, currRecipe);
				InitializeRecipe();
			}

			UpdateGUI();
			listBox.ClearSelected();
		}

		/// <summary>Handles the SelectedIndexChanged event of the listBox control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void listBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			RecipeNameText.Clear();
			textBox.Clear();

			if (listBox.SelectedIndex >= 0 && listBox.SelectedIndex < recipeMngr.CurrentNumberOfItems())
			{
				InitializeRecipe();
				currRecipe = recipeMngr.GetRecipeAt(listBox.SelectedIndex);
				textBox.Text = currRecipe.Description;
				CategoryCombo.SelectedIndex = (int)currRecipe.Category;
				RecipeNameText.Text = currRecipe.Name;
			}
		}

		/// <summary>Handles the Click event of the ClearSelect control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void ClearSelect_Click(object sender, EventArgs e)
		{
			listBox.ClearSelected();
			InitializeRecipe();
		}

		/// <summary>Handles the Click event of the deleteAll control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void deleteAll_Click(object sender, EventArgs e)
		{
			recipeMngr.DeleteAllRecipes();
			listBox.ClearSelected();
			UpdateGUI();
		}
	}
}