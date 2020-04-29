namespace Assignment5
{
	partial class MainForm
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
			this.lastNameTxt = new System.Windows.Forms.TextBox();
			this.firstNameTxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.countryCombo = new System.Windows.Forms.ComboBox();
			this.zipTxt = new System.Windows.Forms.TextBox();
			this.cityTxt = new System.Windows.Forms.TextBox();
			this.streetTxt = new System.Windows.Forms.TextBox();
			this.countryadaTxt = new System.Windows.Forms.Label();
			this.ddd = new System.Windows.Forms.Label();
			this.adas = new System.Windows.Forms.Label();
			this.ad = new System.Windows.Forms.Label();
			this.addBtn = new System.Windows.Forms.Button();
			this.changeBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.listBox = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.recordsLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lastNameTxt);
			this.groupBox1.Controls.Add(this.firstNameTxt);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(20, 35);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
			this.groupBox1.Size = new System.Drawing.Size(562, 143);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Name";
			// 
			// lastNameTxt
			// 
			this.lastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lastNameTxt.Location = new System.Drawing.Point(125, 89);
			this.lastNameTxt.Margin = new System.Windows.Forms.Padding(1);
			this.lastNameTxt.Name = "lastNameTxt";
			this.lastNameTxt.Size = new System.Drawing.Size(411, 26);
			this.lastNameTxt.TabIndex = 3;
			// 
			// firstNameTxt
			// 
			this.firstNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstNameTxt.Location = new System.Drawing.Point(125, 35);
			this.firstNameTxt.Margin = new System.Windows.Forms.Padding(1);
			this.firstNameTxt.Name = "firstNameTxt";
			this.firstNameTxt.Size = new System.Drawing.Size(411, 26);
			this.firstNameTxt.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 89);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Last Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 35);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "First Name";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.countryCombo);
			this.groupBox3.Controls.Add(this.zipTxt);
			this.groupBox3.Controls.Add(this.cityTxt);
			this.groupBox3.Controls.Add(this.streetTxt);
			this.groupBox3.Controls.Add(this.countryadaTxt);
			this.groupBox3.Controls.Add(this.ddd);
			this.groupBox3.Controls.Add(this.adas);
			this.groupBox3.Controls.Add(this.ad);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(20, 206);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(1);
			this.groupBox3.Size = new System.Drawing.Size(562, 189);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Address";
			// 
			// countryCombo
			// 
			this.countryCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countryCombo.FormattingEnabled = true;
			this.countryCombo.Location = new System.Drawing.Point(123, 143);
			this.countryCombo.Margin = new System.Windows.Forms.Padding(1);
			this.countryCombo.Name = "countryCombo";
			this.countryCombo.Size = new System.Drawing.Size(413, 28);
			this.countryCombo.TabIndex = 7;
			// 
			// zipTxt
			// 
			this.zipTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.zipTxt.Location = new System.Drawing.Point(125, 108);
			this.zipTxt.Margin = new System.Windows.Forms.Padding(1);
			this.zipTxt.Name = "zipTxt";
			this.zipTxt.Size = new System.Drawing.Size(411, 26);
			this.zipTxt.TabIndex = 6;
			// 
			// cityTxt
			// 
			this.cityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cityTxt.Location = new System.Drawing.Point(123, 71);
			this.cityTxt.Margin = new System.Windows.Forms.Padding(1);
			this.cityTxt.Name = "cityTxt";
			this.cityTxt.Size = new System.Drawing.Size(413, 26);
			this.cityTxt.TabIndex = 5;
			// 
			// streetTxt
			// 
			this.streetTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.streetTxt.Location = new System.Drawing.Point(125, 30);
			this.streetTxt.Margin = new System.Windows.Forms.Padding(1);
			this.streetTxt.Name = "streetTxt";
			this.streetTxt.Size = new System.Drawing.Size(411, 26);
			this.streetTxt.TabIndex = 4;
			// 
			// countryadaTxt
			// 
			this.countryadaTxt.AutoSize = true;
			this.countryadaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countryadaTxt.Location = new System.Drawing.Point(19, 143);
			this.countryadaTxt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.countryadaTxt.Name = "countryadaTxt";
			this.countryadaTxt.Size = new System.Drawing.Size(67, 20);
			this.countryadaTxt.TabIndex = 3;
			this.countryadaTxt.Text = "Country";
			// 
			// ddd
			// 
			this.ddd.AutoSize = true;
			this.ddd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ddd.Location = new System.Drawing.Point(19, 108);
			this.ddd.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.ddd.Name = "ddd";
			this.ddd.Size = new System.Drawing.Size(75, 20);
			this.ddd.TabIndex = 2;
			this.ddd.Text = "Zip Code";
			// 
			// adas
			// 
			this.adas.AutoSize = true;
			this.adas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adas.Location = new System.Drawing.Point(19, 74);
			this.adas.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.adas.Name = "adas";
			this.adas.Size = new System.Drawing.Size(38, 20);
			this.adas.TabIndex = 1;
			this.adas.Text = "City";
			// 
			// ad
			// 
			this.ad.AutoSize = true;
			this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ad.Location = new System.Drawing.Point(19, 38);
			this.ad.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.ad.Name = "ad";
			this.ad.Size = new System.Drawing.Size(54, 20);
			this.ad.TabIndex = 0;
			this.ad.Text = "Street";
			// 
			// addBtn
			// 
			this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addBtn.Location = new System.Drawing.Point(609, 70);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(146, 39);
			this.addBtn.TabIndex = 3;
			this.addBtn.Text = "Add";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// changeBtn
			// 
			this.changeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.changeBtn.Location = new System.Drawing.Point(609, 182);
			this.changeBtn.Name = "changeBtn";
			this.changeBtn.Size = new System.Drawing.Size(146, 40);
			this.changeBtn.TabIndex = 4;
			this.changeBtn.Text = "Change";
			this.changeBtn.UseVisualStyleBackColor = true;
			this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteBtn.Location = new System.Drawing.Point(609, 295);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(146, 39);
			this.deleteBtn.TabIndex = 5;
			this.deleteBtn.Text = "Delete";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// listBox
			// 
			this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 20;
			this.listBox.Location = new System.Drawing.Point(20, 474);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(1003, 404);
			this.listBox.TabIndex = 6;
			this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(739, 435);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(200, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "No. of registered records ";
			// 
			// recordsLabel
			// 
			this.recordsLabel.AutoSize = true;
			this.recordsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.recordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.recordsLabel.Location = new System.Drawing.Point(957, 435);
			this.recordsLabel.Name = "recordsLabel";
			this.recordsLabel.Size = new System.Drawing.Size(55, 22);
			this.recordsLabel.TabIndex = 8;
			this.recordsLabel.Text = "label4";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1052, 901);
			this.Controls.Add(this.recordsLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.changeBtn);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(1);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox lastNameTxt;
		private System.Windows.Forms.TextBox firstNameTxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label countryadaTxt;
		private System.Windows.Forms.Label ddd;
		private System.Windows.Forms.Label adas;
		private System.Windows.Forms.Label ad;
		private System.Windows.Forms.TextBox streetTxt;
		private System.Windows.Forms.TextBox cityTxt;
		private System.Windows.Forms.TextBox zipTxt;
		private System.Windows.Forms.ComboBox countryCombo;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.Button changeBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label recordsLabel;
	}
}

