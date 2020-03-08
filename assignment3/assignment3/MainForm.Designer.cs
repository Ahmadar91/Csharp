namespace assignment3
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
			this.odoMeter = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.currentReadingTxtBox = new System.Windows.Forms.TextBox();
			this.previousReadingTxtBox = new System.Windows.Forms.TextBox();
			this.currentAmountTxtBox = new System.Windows.Forms.TextBox();
			this.priceTxtBox = new System.Windows.Forms.TextBox();
			this.calculateButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.FuelKrLItResult = new System.Windows.Forms.Label();
			this.FuelLitKmResult = new System.Windows.Forms.Label();
			this.FuelLitMetricResult = new System.Windows.Forms.Label();
			this.FuelLitSweResult = new System.Windows.Forms.Label();
			this.CostperKiloResult = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.MetricRadio = new System.Windows.Forms.RadioButton();
			this.USRadio = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.BMICalcualteButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// odoMeter
			// 
			this.odoMeter.AutoSize = true;
			this.odoMeter.ForeColor = System.Drawing.Color.Green;
			this.odoMeter.Location = new System.Drawing.Point(21, 49);
			this.odoMeter.Margin = new System.Windows.Forms.Padding(5);
			this.odoMeter.Name = "odoMeter";
			this.odoMeter.Size = new System.Drawing.Size(481, 37);
			this.odoMeter.TabIndex = 1;
			this.odoMeter.Text = "Current Odometer Reading (Km)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Green;
			this.label3.Location = new System.Drawing.Point(21, 109);
			this.label3.Margin = new System.Windows.Forms.Padding(5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(497, 37);
			this.label3.TabIndex = 2;
			this.label3.Text = "Previous Odometer Reading (Km)";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Green;
			this.label4.Location = new System.Drawing.Point(16, 179);
			this.label4.Margin = new System.Windows.Forms.Padding(5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(551, 37);
			this.label4.TabIndex = 3;
			this.label4.Text = "Current amount of fuel tanked (Liters)";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Green;
			this.label1.Location = new System.Drawing.Point(21, 251);
			this.label1.Margin = new System.Windows.Forms.Padding(5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(215, 37);
			this.label1.TabIndex = 4;
			this.label1.Text = "Price per Liter";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// currentReadingTxtBox
			// 
			this.currentReadingTxtBox.Location = new System.Drawing.Point(649, 130);
			this.currentReadingTxtBox.Name = "currentReadingTxtBox";
			this.currentReadingTxtBox.Size = new System.Drawing.Size(280, 44);
			this.currentReadingTxtBox.TabIndex = 5;
			this.currentReadingTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// previousReadingTxtBox
			// 
			this.previousReadingTxtBox.Location = new System.Drawing.Point(649, 190);
			this.previousReadingTxtBox.Name = "previousReadingTxtBox";
			this.previousReadingTxtBox.Size = new System.Drawing.Size(280, 44);
			this.previousReadingTxtBox.TabIndex = 6;
			// 
			// currentAmountTxtBox
			// 
			this.currentAmountTxtBox.Location = new System.Drawing.Point(649, 260);
			this.currentAmountTxtBox.Name = "currentAmountTxtBox";
			this.currentAmountTxtBox.Size = new System.Drawing.Size(280, 44);
			this.currentAmountTxtBox.TabIndex = 7;
			// 
			// priceTxtBox
			// 
			this.priceTxtBox.Location = new System.Drawing.Point(649, 332);
			this.priceTxtBox.Name = "priceTxtBox";
			this.priceTxtBox.Size = new System.Drawing.Size(280, 44);
			this.priceTxtBox.TabIndex = 8;
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(194, 325);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(420, 86);
			this.calculateButton.TabIndex = 9;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Green;
			this.label5.Location = new System.Drawing.Point(77, 605);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(389, 37);
			this.label5.TabIndex = 11;
			this.label5.Text = "Fuel Consumption (Km/lit)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Green;
			this.label6.Location = new System.Drawing.Point(72, 664);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(384, 37);
			this.label6.TabIndex = 12;
			this.label6.Text = "Fuel Consumption (lit/km)";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.Green;
			this.label7.Location = new System.Drawing.Point(72, 724);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(502, 37);
			this.label7.TabIndex = 13;
			this.label7.Text = "Fuel Consumption (lit/ Metric Mile)";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.Green;
			this.label8.Location = new System.Drawing.Point(72, 786);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(477, 37);
			this.label8.TabIndex = 14;
			this.label8.Text = "Fuel Consumption (lit/ Swe Mile)";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.Color.Green;
			this.label9.Location = new System.Drawing.Point(72, 840);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(281, 37);
			this.label9.TabIndex = 15;
			this.label9.Text = "Cost per Kilometer";
			// 
			// FuelKrLItResult
			// 
			this.FuelKrLItResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.FuelKrLItResult.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FuelKrLItResult.Location = new System.Drawing.Point(649, 594);
			this.FuelKrLItResult.Name = "FuelKrLItResult";
			this.FuelKrLItResult.Size = new System.Drawing.Size(287, 48);
			this.FuelKrLItResult.TabIndex = 16;
			this.FuelKrLItResult.Text = "label10";
			// 
			// FuelLitKmResult
			// 
			this.FuelLitKmResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.FuelLitKmResult.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FuelLitKmResult.Location = new System.Drawing.Point(649, 653);
			this.FuelLitKmResult.Name = "FuelLitKmResult";
			this.FuelLitKmResult.Size = new System.Drawing.Size(287, 48);
			this.FuelLitKmResult.TabIndex = 17;
			this.FuelLitKmResult.Text = "label11";
			// 
			// FuelLitMetricResult
			// 
			this.FuelLitMetricResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.FuelLitMetricResult.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FuelLitMetricResult.Location = new System.Drawing.Point(649, 713);
			this.FuelLitMetricResult.Name = "FuelLitMetricResult";
			this.FuelLitMetricResult.Size = new System.Drawing.Size(287, 48);
			this.FuelLitMetricResult.TabIndex = 18;
			this.FuelLitMetricResult.Text = "label12";
			// 
			// FuelLitSweResult
			// 
			this.FuelLitSweResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.FuelLitSweResult.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FuelLitSweResult.Location = new System.Drawing.Point(649, 775);
			this.FuelLitSweResult.Name = "FuelLitSweResult";
			this.FuelLitSweResult.Size = new System.Drawing.Size(287, 48);
			this.FuelLitSweResult.TabIndex = 19;
			this.FuelLitSweResult.Text = "label13";
			// 
			// CostperKiloResult
			// 
			this.CostperKiloResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.CostperKiloResult.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CostperKiloResult.Location = new System.Drawing.Point(649, 829);
			this.CostperKiloResult.Name = "CostperKiloResult";
			this.CostperKiloResult.Size = new System.Drawing.Size(287, 48);
			this.CostperKiloResult.TabIndex = 20;
			this.CostperKiloResult.Text = "label14";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.odoMeter);
			this.groupBox1.Controls.Add(this.calculateButton);
			this.groupBox1.ForeColor = System.Drawing.Color.Blue;
			this.groupBox1.Location = new System.Drawing.Point(56, 81);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(932, 880);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fuel";
			// 
			// groupBox2
			// 
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox2.Location = new System.Drawing.Point(6, 445);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(908, 429);
			this.groupBox2.TabIndex = 22;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Results";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.BMICalcualteButton);
			this.groupBox3.Controls.Add(this.textBox3);
			this.groupBox3.Controls.Add(this.textBox2);
			this.groupBox3.Controls.Add(this.textBox1);
			this.groupBox3.Controls.Add(this.USRadio);
			this.groupBox3.Controls.Add(this.MetricRadio);
			this.groupBox3.Controls.Add(this.groupBox4);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.ForeColor = System.Drawing.Color.Blue;
			this.groupBox3.Location = new System.Drawing.Point(994, 81);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1542, 880);
			this.groupBox3.TabIndex = 22;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "BMI";
			this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Green;
			this.label2.Location = new System.Drawing.Point(72, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(181, 37);
			this.label2.TabIndex = 0;
			this.label2.Text = "Your Name";
			this.label2.Click += new System.EventHandler(this.label2_Click_1);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.Green;
			this.label10.Location = new System.Drawing.Point(72, 112);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(166, 37);
			this.label10.TabIndex = 1;
			this.label10.Text = "Hight (cm)";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.ForeColor = System.Drawing.Color.Green;
			this.label11.Location = new System.Drawing.Point(72, 179);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(187, 37);
			this.label11.TabIndex = 2;
			this.label11.Text = "Weight (Kg)";
			// 
			// groupBox4
			// 
			this.groupBox4.Location = new System.Drawing.Point(37, 427);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(1474, 447);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Results for";
			// 
			// MetricRadio
			// 
			this.MetricRadio.AutoSize = true;
			this.MetricRadio.ForeColor = System.Drawing.Color.Green;
			this.MetricRadio.Location = new System.Drawing.Point(1088, 112);
			this.MetricRadio.Name = "MetricRadio";
			this.MetricRadio.Size = new System.Drawing.Size(339, 41);
			this.MetricRadio.TabIndex = 4;
			this.MetricRadio.TabStop = true;
			this.MetricRadio.Text = "Metric Unit (kg, cm)";
			this.MetricRadio.UseVisualStyleBackColor = true;
			this.MetricRadio.CheckedChanged += new System.EventHandler(this.MetricRadio_CheckedChanged);
			// 
			// USRadio
			// 
			this.USRadio.AutoSize = true;
			this.USRadio.ForeColor = System.Drawing.Color.Green;
			this.USRadio.Location = new System.Drawing.Point(1088, 177);
			this.USRadio.Name = "USRadio";
			this.USRadio.Size = new System.Drawing.Size(299, 41);
			this.USRadio.TabIndex = 5;
			this.USRadio.TabStop = true;
			this.USRadio.Text = "US unit (lb, inch)";
			this.USRadio.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(377, 42);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(1010, 44);
			this.textBox1.TabIndex = 6;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(377, 109);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(373, 44);
			this.textBox2.TabIndex = 7;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(377, 179);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(373, 44);
			this.textBox3.TabIndex = 8;
			// 
			// BMICalcualteButton
			// 
			this.BMICalcualteButton.Location = new System.Drawing.Point(563, 304);
			this.BMICalcualteButton.Name = "BMICalcualteButton";
			this.BMICalcualteButton.Size = new System.Drawing.Size(474, 86);
			this.BMICalcualteButton.TabIndex = 9;
			this.BMICalcualteButton.Text = "Calculate";
			this.BMICalcualteButton.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(2585, 1482);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.CostperKiloResult);
			this.Controls.Add(this.FuelLitSweResult);
			this.Controls.Add(this.FuelLitMetricResult);
			this.Controls.Add(this.FuelLitKmResult);
			this.Controls.Add(this.FuelKrLItResult);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.priceTxtBox);
			this.Controls.Add(this.currentAmountTxtBox);
			this.Controls.Add(this.previousReadingTxtBox);
			this.Controls.Add(this.currentReadingTxtBox);
			this.Controls.Add(this.groupBox1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label odoMeter;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox currentReadingTxtBox;
		private System.Windows.Forms.TextBox previousReadingTxtBox;
		private System.Windows.Forms.TextBox currentAmountTxtBox;
		private System.Windows.Forms.TextBox priceTxtBox;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label FuelKrLItResult;
		private System.Windows.Forms.Label FuelLitKmResult;
		private System.Windows.Forms.Label FuelLitMetricResult;
		private System.Windows.Forms.Label FuelLitSweResult;
		private System.Windows.Forms.Label CostperKiloResult;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BMICalcualteButton;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RadioButton USRadio;
		private System.Windows.Forms.RadioButton MetricRadio;
		private System.Windows.Forms.GroupBox groupBox4;
	}
}

