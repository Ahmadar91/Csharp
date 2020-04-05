namespace assignment4
{
	partial class FormIngredients
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
			this.label1 = new System.Windows.Forms.Label();
			this.NumLabel = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.IngredientText = new System.Windows.Forms.TextBox();
			this.AddRecipeButton = new System.Windows.Forms.Button();
			this.RecipeListBox = new System.Windows.Forms.ListBox();
			this.EditRecipeButton = new System.Windows.Forms.Button();
			this.DeleteRecipeButton = new System.Windows.Forms.Button();
			this.OkButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Num of ingredients";
			// 
			// NumLabel
			// 
			this.NumLabel.AutoSize = true;
			this.NumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumLabel.Location = new System.Drawing.Point(513, 46);
			this.NumLabel.Name = "NumLabel";
			this.NumLabel.Size = new System.Drawing.Size(44, 20);
			this.NumLabel.TabIndex = 1;
			this.NumLabel.Text = "Num";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.DeleteRecipeButton);
			this.groupBox1.Controls.Add(this.EditRecipeButton);
			this.groupBox1.Controls.Add(this.RecipeListBox);
			this.groupBox1.Controls.Add(this.AddRecipeButton);
			this.groupBox1.Controls.Add(this.IngredientText);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 84);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(598, 590);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ingredient";
			// 
			// IngredientText
			// 
			this.IngredientText.Location = new System.Drawing.Point(17, 43);
			this.IngredientText.Name = "IngredientText";
			this.IngredientText.Size = new System.Drawing.Size(462, 27);
			this.IngredientText.TabIndex = 0;
			// 
			// AddRecipeButton
			// 
			this.AddRecipeButton.Location = new System.Drawing.Point(502, 43);
			this.AddRecipeButton.Name = "AddRecipeButton";
			this.AddRecipeButton.Size = new System.Drawing.Size(88, 27);
			this.AddRecipeButton.TabIndex = 1;
			this.AddRecipeButton.Text = "Add";
			this.AddRecipeButton.UseVisualStyleBackColor = true;
			this.AddRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
			// 
			// RecipeListBox
			// 
			this.RecipeListBox.FormattingEnabled = true;
			this.RecipeListBox.ItemHeight = 20;
			this.RecipeListBox.Location = new System.Drawing.Point(17, 102);
			this.RecipeListBox.Name = "RecipeListBox";
			this.RecipeListBox.Size = new System.Drawing.Size(462, 464);
			this.RecipeListBox.TabIndex = 2;
			// 
			// EditRecipeButton
			// 
			this.EditRecipeButton.Location = new System.Drawing.Point(502, 186);
			this.EditRecipeButton.Name = "EditRecipeButton";
			this.EditRecipeButton.Size = new System.Drawing.Size(88, 48);
			this.EditRecipeButton.TabIndex = 3;
			this.EditRecipeButton.Text = "Edit";
			this.EditRecipeButton.UseVisualStyleBackColor = true;
			// 
			// DeleteRecipeButton
			// 
			this.DeleteRecipeButton.Location = new System.Drawing.Point(502, 240);
			this.DeleteRecipeButton.Name = "DeleteRecipeButton";
			this.DeleteRecipeButton.Size = new System.Drawing.Size(88, 48);
			this.DeleteRecipeButton.TabIndex = 4;
			this.DeleteRecipeButton.Text = "Delete";
			this.DeleteRecipeButton.UseVisualStyleBackColor = true;
			// 
			// OkButton
			// 
			this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OkButton.Location = new System.Drawing.Point(91, 686);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(149, 45);
			this.OkButton.TabIndex = 3;
			this.OkButton.Text = "Ok";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(335, 686);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(149, 45);
			this.CancelButton.TabIndex = 4;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			// 
			// FormIngredients
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 743);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.NumLabel);
			this.Controls.Add(this.label1);
			this.Name = "FormIngredients";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label NumLabel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button AddRecipeButton;
		private System.Windows.Forms.TextBox IngredientText;
		private System.Windows.Forms.Button DeleteRecipeButton;
		private System.Windows.Forms.Button EditRecipeButton;
		private System.Windows.Forms.ListBox RecipeListBox;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button CancelButton;
	}
}