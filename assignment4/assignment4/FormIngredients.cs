
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
			RecipeListBox.Items.Clear();
			RecipeListBox.Items.AddRange(m_recipe.IngredientArray);
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





	}
}
