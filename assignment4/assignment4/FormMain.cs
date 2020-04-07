using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace assignment4
{
	public partial class FormMain : Form
	{
		private const int numOfIngredients = 20;
		private const int maxNumOfElements = 50;
		RecipeManager recipeMngr;
		Recipe currRecipe;
		public FormMain()
		{
			InitializeComponent();
			recipeMngr = new RecipeManager(maxNumOfElements);
			InitializeRecipe();

			InitializeGUI();
		}

		private void InitializeRecipe()
		{
			currRecipe = new Recipe(numOfIngredients);

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

			FormIngredients dlg = new FormIngredients(currRecipe);
			DialogResult dlgResult = dlg.ShowDialog();

			if (dlgResult == DialogResult.OK)
			{
				if (currRecipe.CurrentNumOfIngredients() <= 0)
				{
					MessageBox.Show("No Ingriedients specified!");

					recipeMngr.Add(currRecipe);
					UpdateGUI();
				}
			}
		}


		private void AddRecipeBox_Click(object sender, EventArgs e)
		{

			// if (currRecipe != null)
			// {
			// 	
			// }
			//else
			{
				if (!CheckInput())
				{
					return;
				}

				currRecipe.Category = (Category)CategoryCombo.SelectedIndex;
				currRecipe.Name = RecipeNameText.Text.Trim();
				currRecipe.Description = textBox.Text.Trim();
				recipeMngr.Add(currRecipe);
				UpdateGUI();
				InitializeRecipe();
			}
		

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

			string[] recipeListStrings = recipeMngr.RecipeListToString();
			listBox.Items.Clear();
			RecipeNameText.Clear();
			textBox.Clear();
			listBox.Items.AddRange(recipeListStrings);

			InitializeOutput();
		}

		private void DelButton_Click(object sender, EventArgs e)
		{
			listBox.Items.Add("clicked");
			recipeMngr.DeleteElement(listBox.SelectedIndex);
			UpdateGUI();
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			if (listBox.SelectedIndex >= 0 && listBox.SelectedIndex < recipeMngr.CurrentNumberOfItems())
			{
				currRecipe.Category = (Category)CategoryCombo.SelectedIndex;
				currRecipe.Name = RecipeNameText.Text.Trim();
				currRecipe.Description = textBox.Text.Trim(); 
				recipeMngr.ChangeElement(listBox.SelectedIndex, currRecipe);
			}
			UpdateGUI();
			listBox.ClearSelected();
			InitializeRecipe();
		}

		private void listBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			RecipeNameText.Clear();
			textBox.Clear();
			if (listBox.SelectedIndex >= 0 && listBox.SelectedIndex < recipeMngr.CurrentNumberOfItems())
			{
				currRecipe = recipeMngr.GetRecipeAt(listBox.SelectedIndex);
				textBox.Text = currRecipe.Description;
				CategoryCombo.SelectedIndex = (int)currRecipe.Category;
				RecipeNameText.Text = currRecipe.Name;
			}
		}

		private void ClearSelect_Click(object sender, EventArgs e)
		{
			listBox.ClearSelected();
			InitializeRecipe();
		}
	}
}
