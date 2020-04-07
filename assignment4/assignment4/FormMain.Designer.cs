namespace assignment4
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox = new System.Windows.Forms.TextBox();
			this.AddIngredientsButton = new System.Windows.Forms.Button();
			this.CategoryCombo = new System.Windows.Forms.ComboBox();
			this.Category = new System.Windows.Forms.Label();
			this.RecipeNameText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.AddRecipeBox = new System.Windows.Forms.Button();
			this.Name = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.listBox = new System.Windows.Forms.ListBox();
			this.DelButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.ClearSelect = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox);
			this.groupBox1.Controls.Add(this.AddIngredientsButton);
			this.groupBox1.Controls.Add(this.CategoryCombo);
			this.groupBox1.Controls.Add(this.Category);
			this.groupBox1.Controls.Add(this.RecipeNameText);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(28, 86);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(7);
			this.groupBox1.Size = new System.Drawing.Size(1340, 1607);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add new recipe";
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(48, 414);
			this.textBox.Margin = new System.Windows.Forms.Padding(7);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(1248, 1146);
			this.textBox.TabIndex = 5;
			// 
			// AddIngredientsButton
			// 
			this.AddIngredientsButton.Location = new System.Drawing.Point(848, 224);
			this.AddIngredientsButton.Margin = new System.Windows.Forms.Padding(7);
			this.AddIngredientsButton.Name = "AddIngredientsButton";
			this.AddIngredientsButton.Size = new System.Drawing.Size(382, 76);
			this.AddIngredientsButton.TabIndex = 4;
			this.AddIngredientsButton.Text = "Add ingredients";
			this.AddIngredientsButton.UseVisualStyleBackColor = true;
			this.AddIngredientsButton.Click += new System.EventHandler(this.AddIngredientsButton_Click);
			// 
			// CategoryCombo
			// 
			this.CategoryCombo.FormattingEnabled = true;
			this.CategoryCombo.Location = new System.Drawing.Point(442, 236);
			this.CategoryCombo.Margin = new System.Windows.Forms.Padding(7);
			this.CategoryCombo.Name = "CategoryCombo";
			this.CategoryCombo.Size = new System.Drawing.Size(294, 45);
			this.CategoryCombo.TabIndex = 3;
			// 
			// Category
			// 
			this.Category.AutoSize = true;
			this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Category.Location = new System.Drawing.Point(38, 236);
			this.Category.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.Category.Name = "Category";
			this.Category.Size = new System.Drawing.Size(188, 47);
			this.Category.TabIndex = 2;
			this.Category.Text = "Category";
			// 
			// RecipeNameText
			// 
			this.RecipeNameText.Location = new System.Drawing.Point(442, 123);
			this.RecipeNameText.Margin = new System.Windows.Forms.Padding(7);
			this.RecipeNameText.Name = "RecipeNameText";
			this.RecipeNameText.Size = new System.Drawing.Size(812, 44);
			this.RecipeNameText.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 123);
			this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(368, 47);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name of the recipe";
			// 
			// AddRecipeBox
			// 
			this.AddRecipeBox.Location = new System.Drawing.Point(107, 1730);
			this.AddRecipeBox.Margin = new System.Windows.Forms.Padding(7);
			this.AddRecipeBox.Name = "AddRecipeBox";
			this.AddRecipeBox.Size = new System.Drawing.Size(1152, 109);
			this.AddRecipeBox.TabIndex = 1;
			this.AddRecipeBox.Text = "Add Recipe";
			this.AddRecipeBox.UseVisualStyleBackColor = true;
			this.AddRecipeBox.Click += new System.EventHandler(this.AddRecipeBox_Click);
			// 
			// Name
			// 
			this.Name.AutoSize = true;
			this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name.Location = new System.Drawing.Point(1427, 215);
			this.Name.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.Name.Name = "Name";
			this.Name.Size = new System.Drawing.Size(130, 47);
			this.Name.TabIndex = 2;
			this.Name.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1924, 183);
			this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 94);
			this.label2.TabIndex = 3;
			this.label2.Text = "No. of\r\n ingred";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(2308, 222);
			this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(188, 47);
			this.label3.TabIndex = 4;
			this.label3.Text = "Category";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(2719, 222);
			this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(229, 47);
			this.label4.TabIndex = 5;
			this.label4.Text = "Description";
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 37;
			this.listBox.Location = new System.Drawing.Point(1437, 310);
			this.listBox.Margin = new System.Windows.Forms.Padding(7);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(1681, 1336);
			this.listBox.TabIndex = 6;
			this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
			// 
			// DelButton
			// 
			this.DelButton.Location = new System.Drawing.Point(1730, 1730);
			this.DelButton.Margin = new System.Windows.Forms.Padding(7);
			this.DelButton.Name = "DelButton";
			this.DelButton.Size = new System.Drawing.Size(283, 106);
			this.DelButton.TabIndex = 7;
			this.DelButton.Text = "Delete";
			this.DelButton.UseVisualStyleBackColor = true;
			this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.Location = new System.Drawing.Point(2173, 1730);
			this.EditButton.Margin = new System.Windows.Forms.Padding(7);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(283, 109);
			this.EditButton.TabIndex = 8;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// ClearSelect
			// 
			this.ClearSelect.Location = new System.Drawing.Point(2594, 1727);
			this.ClearSelect.Margin = new System.Windows.Forms.Padding(7);
			this.ClearSelect.Name = "ClearSelect";
			this.ClearSelect.Size = new System.Drawing.Size(283, 109);
			this.ClearSelect.TabIndex = 9;
			this.ClearSelect.Text = "Clear Selected";
			this.ClearSelect.UseVisualStyleBackColor = true;
			this.ClearSelect.Click += new System.EventHandler(this.ClearSelect_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(3209, 1922);
			this.Controls.Add(this.ClearSelect);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.DelButton);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Name);
			this.Controls.Add(this.AddRecipeBox);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(7);
			this.Name = "FormMain";
			this.Text = "Apu\'s Cook Book";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button AddRecipeBox;
		private System.Windows.Forms.TextBox RecipeNameText;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Button AddIngredientsButton;
		private System.Windows.Forms.ComboBox CategoryCombo;
		private System.Windows.Forms.Label Category;
		private System.Windows.Forms.Label Name;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Button DelButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button ClearSelect;
	}
}

