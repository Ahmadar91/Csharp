using System.Windows.Forms;

namespace assignment4
{
	public partial class FormIngredients : Form
	{
		private Recipe m_recipe;


		/// <summary>Initializes a new instance of the <see cref="FormIngredients" /> class.</summary>
		/// <param name="recipe">The recipe.</param>
		public FormIngredients(Recipe recipe)
		{
			InitializeComponent();
			m_recipe = recipe;
			if (string.IsNullOrEmpty(recipe.Name))
			{
				Text = "No Recipe Name";
			}
			else

				Text = recipe.Name + "Add ingredients";


			InitializeGUI();
			UpdateGUI();
		}

		/// <summary>Initializes the GUI.</summary>
		private void InitializeGUI()
		{
			if (m_recipe.IngredientArray == null)
			{
				m_recipe.IngredientArray = new string[m_recipe.MaxNumOfIngredients];
			}

			RecipeListBox.Items.Clear();
			toolTip2.SetToolTip(IngredientText, "Example: 2 dl milk");
			NumLabel.Text = m_recipe.CurrentNumOfIngredients().ToString();
			RecipeListBox.Items.AddRange(m_recipe.IngredientArray);
		}

		/// <summary>Populates the ListBox.</summary>
		private void PopulateListBox()
		{
			RecipeListBox.Items.Clear();
			for (int i = 0; i < m_recipe.IngredientArray.Length; i++)
			{
				if (!string.IsNullOrEmpty(m_recipe.IngredientArray[i]))
				{
					RecipeListBox.Items.Add(m_recipe.IngredientArray[i]);
				}
			}
		}


		/// <summary>Handles the Click event of the AddRecipeButton control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
		private void AddRecipeButton_Click(object sender, System.EventArgs e)
		{
			if (!CheckInput())
			{
				return;
			}

			m_recipe.AddIngredient(IngredientText.Text);

			UpdateGUI();
		}

		/// <summary>Handles the Click event of the OkButton control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
		private void OkButton_Click(object sender, System.EventArgs e)
		{
		}


		/// <summary>Updates the GUI.</summary>
		private void UpdateGUI()
		{
			IngredientText.Clear();
			NumLabel.Text = m_recipe.CurrentNumOfIngredients().ToString();
			PopulateListBox();
		}

		/// <summary>Checks the input.</summary>
		/// <returns></returns>
		private bool CheckInput()
		{
			return ReadIngredientText();
		}

		/// <summary>Reads the ingredient text.</summary>
		/// <returns></returns>
		private bool ReadIngredientText()
		{
			if (!string.IsNullOrEmpty(IngredientText.Text))
			{
				return true;
			}

			return false;
		}

		/// <summary>Handles the Click event of the EditRecipeButton control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
		private void EditRecipeButton_Click(object sender, System.EventArgs e)
		{
			if (RecipeListBox.SelectedIndex >= 0 && RecipeListBox.SelectedIndex < m_recipe.MaxNumOfIngredients)
			{
				m_recipe.ChangeIngredientAt(RecipeListBox.SelectedIndex, IngredientText.Text);
			}

			UpdateGUI();
		}

		/// <summary>Handles the Click event of the DeleteRecipeButton control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
		private void DeleteRecipeButton_Click(object sender, System.EventArgs e)
		{
			IngredientText.Clear();
			if (RecipeListBox.SelectedIndex >= 0 && RecipeListBox.SelectedIndex < m_recipe.MaxNumOfIngredients)
			{
				m_recipe.IngredientArray[RecipeListBox.SelectedIndex] = null;
			}

			UpdateGUI();
		}

		/// <summary>Handles the SelectedIndexChanged event of the RecipeListBox control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
		private void RecipeListBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			IngredientText.Clear();
			if (RecipeListBox.SelectedIndex >= 0 && RecipeListBox.SelectedIndex < m_recipe.MaxNumOfIngredients)
			{
				IngredientText.Text = m_recipe.IngredientArray[RecipeListBox.SelectedIndex];
			}
		}
	}
}