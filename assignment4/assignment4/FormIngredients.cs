
using System.Windows.Forms;

namespace assignment4
{



	public partial class FormIngredients : Form
	{
		private Recipe m_recipe;



		public FormIngredients(Recipe recipe)
		{
			InitializeComponent();
			m_recipe = recipe;
			if (string.IsNullOrEmpty(recipe.Name))
			{
				this.Text = "No Recipe Name";
			}
			else

				this.Text = recipe.Name + "Add ingredients";


			InitializeGUI();
			UpdateGUI();
		}

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

		private void PopulateListBox()
		{
			RecipeListBox.Items.Clear();
			for (int i = 0; i < m_recipe.IngredientArray.Length; i++)
			{
				if (string.IsNullOrEmpty(m_recipe.IngredientArray[i]))
				{

				}
				else
					RecipeListBox.Items.Add(m_recipe.IngredientArray[i]);
			}
		}


		private void AddRecipeButton_Click(object sender, System.EventArgs e)
		{
			if (!CheckInput())
			{
				return;
			}

			m_recipe.AddIngredient(IngredientText.Text);

			UpdateGUI();

		}

		private void OkButton_Click(object sender, System.EventArgs e)
		{

		}


		private void UpdateGUI()
		{
			IngredientText.Clear();
			NumLabel.Text = m_recipe.CurrentNumOfIngredients().ToString();
			PopulateListBox();
		}

		private bool CheckInput()
		{


			return ReadIngredientText();
		}

		private bool ReadIngredientText()
		{
			if (!string.IsNullOrEmpty(IngredientText.Text))
			{
				return true;
			}
			return false;
		}

		private void EditRecipeButton_Click(object sender, System.EventArgs e)
		{

			if (RecipeListBox.SelectedIndex >= 0 && RecipeListBox.SelectedIndex < m_recipe.MaxNumOfIngredients)
			{
				m_recipe.IngredientArray[RecipeListBox.SelectedIndex] = IngredientText.Text;

			}

			UpdateGUI();
		}

		private void DeleteRecipeButton_Click(object sender, System.EventArgs e)
		{
			IngredientText.Clear();
			if (RecipeListBox.SelectedIndex >= 0 && RecipeListBox.SelectedIndex < m_recipe.MaxNumOfIngredients)
			{
				m_recipe.IngredientArray[RecipeListBox.SelectedIndex] = null;

			}

			UpdateGUI();
		}

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
