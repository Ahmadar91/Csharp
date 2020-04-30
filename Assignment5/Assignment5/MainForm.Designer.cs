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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.listBox = new System.Windows.Forms.ListBox();
			this.addBtn = new System.Windows.Forms.Button();
			this.changeBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Id";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(195, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 37);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(504, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(355, 37);
			this.label3.TabIndex = 2;
			this.label3.Text = "Steet, Zip, City, Country";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(1191, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(374, 37);
			this.label4.TabIndex = 3;
			this.label4.Text = "Office and Home Phones";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(1908, 71);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 37);
			this.label5.TabIndex = 4;
			this.label5.Text = "Email";
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 37;
			this.listBox.Location = new System.Drawing.Point(75, 173);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(2070, 929);
			this.listBox.TabIndex = 5;
			this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
			// 
			// addBtn
			// 
			this.addBtn.Location = new System.Drawing.Point(511, 1166);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(243, 92);
			this.addBtn.TabIndex = 6;
			this.addBtn.Text = "Add";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// changeBtn
			// 
			this.changeBtn.Location = new System.Drawing.Point(956, 1166);
			this.changeBtn.Name = "changeBtn";
			this.changeBtn.Size = new System.Drawing.Size(254, 92);
			this.changeBtn.TabIndex = 7;
			this.changeBtn.Text = "Change";
			this.changeBtn.UseVisualStyleBackColor = true;
			this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.Location = new System.Drawing.Point(1433, 1166);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(254, 92);
			this.deleteBtn.TabIndex = 8;
			this.deleteBtn.Text = "Delete";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2228, 1356);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.changeBtn);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.Button changeBtn;
		private System.Windows.Forms.Button deleteBtn;
	}
}