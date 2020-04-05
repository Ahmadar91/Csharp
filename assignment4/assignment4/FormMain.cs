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
		private Recipe _currRecipe = new Recipe(_NumofIngredients);
		private RecipeManager _recipeMngr = new RecipeManager(_maxNumofElements);
		public FormMain()
		{
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

		}



		private void AddIngredientsButton_Click(object sender, EventArgs e)
		{
			FormIngredients dlg = new FormIngredients(_currRecipe);
			DialogResult dlgResult = dlg.ShowDialog();

			if (dlgResult == DialogResult.OK && _currRecipe.CurrentNumOfIngredients() <= 0)
			{
				MessageBox.Show("No Ingriedients specified!");
				_recipeMngr.Add(_currRecipe);
				UpdateGUI();
			}
		}


		private void AddRecipeBox_Click(object sender, EventArgs e)
		{

		}



		private bool CheckInput()
		{
			return true;
		}


		private void InitializeOutput()
		{

		}
		private void MainForm_Load(object sender, EventArgs e)

		{



		}
		public void UpdateGUI()
		{

		}


	}
}
