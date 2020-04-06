using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4
{
	public partial class FormMain : Form
	{
		private const int _NumofIngredients = 20;
		private const int _maxNumofElements = 50;
		private RecipeManager _recipeMngr = new RecipeManager(_maxNumofElements);
		private Recipe _currRecipe;
		public FormMain()
		{
			_currRecipe = new Recipe(_NumofIngredients);

			InitializeComponent();
			InitializeGUI();
		}
		private void InitializeGUI()
		{
			CategoryCombo.Items.Add("Meat");
			CategoryCombo.Items.Add("Vegetarian");
			CategoryCombo.Items.Add("Fish");
			CategoryCombo.Items.Add("SeaFood");
			listBox.Text = "";
			CategoryCombo.SelectedIndex = 1;

		}



		private void AddIngredientsButton_Click(object sender, EventArgs e)
		{
			FormIngredients dlg = new FormIngredients(_currRecipe);
			DialogResult dlgResult = dlg.ShowDialog();

			if (dlgResult == DialogResult.OK)
			{
				if (_currRecipe.CurrentNumOfIngredients() <= 0)
				{
					MessageBox.Show("No Ingriedients specified!");
					_recipeMngr.Add(_currRecipe);
					UpdateGUI();
				}
			}
		}


		private void AddRecipeBox_Click(object sender, EventArgs e)
		{
			if (!CheckInput())
			{
				return;
			}

			_currRecipe.Category = (Category)CategoryCombo.SelectedIndex;
			_currRecipe.Name = RecipeNameText.Text.Trim();
			_currRecipe.Description = textBox.Text.Trim();
			_recipeMngr.Add(_currRecipe);

			UpdateGUI();
			_currRecipe.DefaultValues();


		}



		private bool CheckInput()
		{


			return ReadName() && ReadDescription();
		}

		private bool ReadDescription()
		{
			if (!string.IsNullOrEmpty(RecipeNameText.Text))
			{
				return true;
			}
			return false;
		}

		private bool ReadName()
		{
			if (!string.IsNullOrEmpty(RecipeNameText.Text))
			{
				return true;
			}
			return false;
		}

		private void InitializeOutput()
		{

		}
		private void MainForm_Load(object sender, EventArgs e)

		{



		}
		public void UpdateGUI()
		{

			string[] recipeListStrings = _recipeMngr.RecipeListToString();
			listBox.Items.Clear();
			RecipeNameText.Clear();
			textBox.Clear();
			listBox.Items.AddRange(recipeListStrings);

			InitializeOutput();
		}


	}
}
