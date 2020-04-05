
using System.Windows.Forms;

namespace assignment4
{



	public partial class FormIngredients : Form
	{
		private Recipe m_recipe;

		public Recipe MRecipe
		{
			get => m_recipe;
			set => m_recipe = value;
		}

		public FormIngredients(Recipe recipe)
		{

			InitializeComponent();
			InitializeGUI();
		}

		private void InitializeGUI()
		{


		}

		private void AddRecipeButton_Click(object sender, System.EventArgs e)
		{

		}

		private void OkButton_Click(object sender, System.EventArgs e)
		{

		}


		private void UpdateGUI()
		{

		}
	}
}
