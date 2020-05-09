namespace assignment6
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
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.openDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox = new System.Windows.Forms.TextBox();
			this.addBtn = new System.Windows.Forms.Button();
			this.changeBtn = new System.Windows.Forms.Button();
			this.delBtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.listBox = new System.Windows.Forms.ListBox();
			this.label = new System.Windows.Forms.Label();
			this.priorityToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(862, 26);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.openDataFileToolStripMenuItem,
            this.saveDataFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
			// 
			// openDataFileToolStripMenuItem
			// 
			this.openDataFileToolStripMenuItem.Name = "openDataFileToolStripMenuItem";
			this.openDataFileToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
			this.openDataFileToolStripMenuItem.Text = "Open DataFile";
			// 
			// saveDataFileToolStripMenuItem
			// 
			this.saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
			this.saveDataFileToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
			this.saveDataFileToolStripMenuItem.Text = "Save DataFile";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(217, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.exitToolStripMenuItem.Text = "Exit               Alt+F4";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 70);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Date and Time";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker.Location = new System.Drawing.Point(192, 68);
			this.dateTimePicker.Margin = new System.Windows.Forms.Padding(1);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dateTimePicker.Size = new System.Drawing.Size(297, 26);
			this.dateTimePicker.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(536, 70);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Priority";
			// 
			// comboBox
			// 
			this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Location = new System.Drawing.Point(651, 71);
			this.comboBox.Margin = new System.Windows.Forms.Padding(1);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(178, 28);
			this.comboBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 134);
			this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "To Do";
			// 
			// textBox
			// 
			this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox.Location = new System.Drawing.Point(163, 134);
			this.textBox.Margin = new System.Windows.Forms.Padding(1);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(666, 26);
			this.textBox.TabIndex = 6;
			// 
			// addBtn
			// 
			this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addBtn.Location = new System.Drawing.Point(238, 196);
			this.addBtn.Margin = new System.Windows.Forms.Padding(1);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(126, 45);
			this.addBtn.TabIndex = 7;
			this.addBtn.Text = "Add";
			this.addBtn.UseVisualStyleBackColor = true;
			// 
			// changeBtn
			// 
			this.changeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.changeBtn.Location = new System.Drawing.Point(432, 196);
			this.changeBtn.Margin = new System.Windows.Forms.Padding(1);
			this.changeBtn.Name = "changeBtn";
			this.changeBtn.Size = new System.Drawing.Size(126, 45);
			this.changeBtn.TabIndex = 8;
			this.changeBtn.Text = "Change";
			this.changeBtn.UseVisualStyleBackColor = true;
			// 
			// delBtn
			// 
			this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delBtn.Location = new System.Drawing.Point(626, 196);
			this.delBtn.Margin = new System.Windows.Forms.Padding(1);
			this.delBtn.Name = "delBtn";
			this.delBtn.Size = new System.Drawing.Size(126, 45);
			this.delBtn.TabIndex = 9;
			this.delBtn.Text = "Delete";
			this.delBtn.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.listBox);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(28, 255);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
			this.groupBox1.Size = new System.Drawing.Size(818, 314);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tasks";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(648, 32);
			this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 20);
			this.label7.TabIndex = 4;
			this.label7.Text = "Discription";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(379, 32);
			this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 20);
			this.label6.TabIndex = 3;
			this.label6.Text = "Priority";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(273, 32);
			this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Hour";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 32);
			this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "Date";
			// 
			// listBox
			// 
			this.listBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 20;
			this.listBox.Location = new System.Drawing.Point(13, 60);
			this.listBox.Margin = new System.Windows.Forms.Padding(1);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(788, 224);
			this.listBox.TabIndex = 0;
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label.Location = new System.Drawing.Point(728, 586);
			this.label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(55, 22);
			this.label.TabIndex = 11;
			this.label.Text = "label4";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Seconds_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(862, 612);
			this.Controls.Add(this.label);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.delBtn);
			this.Controls.Add(this.changeBtn);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(1);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem openDataFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveDataFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.Button changeBtn;
		private System.Windows.Forms.Button delBtn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolTip priorityToolTip;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

