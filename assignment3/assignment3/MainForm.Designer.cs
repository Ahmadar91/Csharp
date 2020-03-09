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
			this.BMICalcualteButton = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.USRadio = new System.Windows.Forms.RadioButton();
			this.MetricRadio = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// odoMeter
			// 
			this.odoMeter.AutoSize = true;
			this.odoMeter.ForeColor = System.Drawing.Color.Green;
			this.odoMeter.Location = new System.Drawing.Point(9, 21);
			this.odoMeter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.odoMeter.Name = "odoMeter";
			this.odoMeter.Size = new System.Drawing.Size(213, 17);
			this.odoMeter.TabIndex = 1;
			this.odoMeter.Text = "Current Odometer Reading (Km)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Green;
			this.label3.Location = new System.Drawing.Point(9, 47);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(221, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Previous Odometer Reading (Km)";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Green;
			this.label4.Location = new System.Drawing.Point(7, 77);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(245, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Current amount of fuel tanked (Liters)";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Green;
			this.label1.Location = new System.Drawing.Point(9, 109);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Price per Liter";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// currentReadingTxtBox
			// 
			this.currentReadingTxtBox.Location = new System.Drawing.Point(273, 56);
			this.currentReadingTxtBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.currentReadingTxtBox.Name = "currentReadingTxtBox";
			this.currentReadingTxtBox.Size = new System.Drawing.Size(120, 22);
			this.currentReadingTxtBox.TabIndex = 5;
			this.currentReadingTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// previousReadingTxtBox
			// 
			this.previousReadingTxtBox.Location = new System.Drawing.Point(273, 82);
			this.previousReadingTxtBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.previousReadingTxtBox.Name = "previousReadingTxtBox";
			this.previousReadingTxtBox.Size = new System.Drawing.Size(120, 22);
			this.previousReadingTxtBox.TabIndex = 6;
			// 
			// currentAmountTxtBox
			// 
			this.currentAmountTxtBox.Location = new System.Drawing.Point(273, 112);
			this.currentAmountTxtBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.currentAmountTxtBox.Name = "currentAmountTxtBox";
			this.currentAmountTxtBox.Size = new System.Drawing.Size(120, 22);
			this.currentAmountTxtBox.TabIndex = 7;
			// 
			// priceTxtBox
			// 
			this.priceTxtBox.Location = new System.Drawing.Point(273, 144);
			this.priceTxtBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.priceTxtBox.Name = "priceTxtBox";
			this.priceTxtBox.Size = new System.Drawing.Size(120, 22);
			this.priceTxtBox.TabIndex = 8;
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(82, 141);
			this.calculateButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(177, 37);
			this.calculateButton.TabIndex = 9;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Green;
			this.label5.Location = new System.Drawing.Point(32, 262);
			this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(169, 17);
			this.label5.TabIndex = 11;
			this.label5.Text = "Fuel Consumption (Km/lit)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Green;
			this.label6.Location = new System.Drawing.Point(30, 287);
			this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(167, 17);
			this.label6.TabIndex = 12;
			this.label6.Text = "Fuel Consumption (lit/km)";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.Green;
			this.label7.Location = new System.Drawing.Point(30, 313);
			this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(220, 17);
			this.label7.TabIndex = 13;
			this.label7.Text = "Fuel Consumption (lit/ Metric Mile)";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.Green;
			this.label8.Location = new System.Drawing.Point(30, 340);
			this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(208, 17);
			this.label8.TabIndex = 14;
			this.label8.Text = "Fuel Consumption (lit/ Swe Mile)";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.Color.Green;
			this.label9.Location = new System.Drawing.Point(30, 363);
			this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(124, 17);
			this.label9.TabIndex = 15;
			this.label9.Text = "Cost per Kilometer";
			// 
			// FuelKrLItResult
			// 
			this.FuelKrLItResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.FuelKrLItResult.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FuelKrLItResult.Location = new System.Drawing.Point(273, 257);
			this.FuelKrLItResult.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.FuelKrLItResult.Name = "FuelKrLItResult";
			this.FuelKrLItResult.Size = new System.Drawing.Size(121, 21);
			this.FuelKrLItResult.TabIndex = 16;
			this.FuelKrLItResult.Text = "label10";
			// 
			// FuelLitKmResult
			// 
			this.FuelLitKmResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.FuelLitKmResult.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FuelLitKmResult.Location = new System.Drawing.Point(273, 282);
			this.FuelLitKmResult.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.FuelLitKmResult.Name = "FuelLitKmResult";
			this.FuelLitKmResult.Size = new System.Drawing.Size(121, 21);
			this.FuelLitKmResult.TabIndex = 17;
			this.FuelLitKmResult.Text = "label11";
			// 
			// FuelLitMetricResult
			// 
			this.FuelLitMetricResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.FuelLitMetricResult.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FuelLitMetricResult.Location = new System.Drawing.Point(273, 308);
			this.FuelLitMetricResult.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.FuelLitMetricResult.Name = "FuelLitMetricResult";
			this.FuelLitMetricResult.Size = new System.Drawing.Size(121, 21);
			this.FuelLitMetricResult.TabIndex = 18;
			this.FuelLitMetricResult.Text = "label12";
			// 
			// FuelLitSweResult
			// 
			this.FuelLitSweResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.FuelLitSweResult.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FuelLitSweResult.Location = new System.Drawing.Point(273, 335);
			this.FuelLitSweResult.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.FuelLitSweResult.Name = "FuelLitSweResult";
			this.FuelLitSweResult.Size = new System.Drawing.Size(121, 21);
			this.FuelLitSweResult.TabIndex = 19;
			this.FuelLitSweResult.Text = "label13";
			// 
			// CostperKiloResult
			// 
			this.CostperKiloResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.CostperKiloResult.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CostperKiloResult.Location = new System.Drawing.Point(273, 358);
			this.CostperKiloResult.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.CostperKiloResult.Name = "CostperKiloResult";
			this.CostperKiloResult.Size = new System.Drawing.Size(121, 21);
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
			this.groupBox1.Location = new System.Drawing.Point(24, 35);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.groupBox1.Size = new System.Drawing.Size(392, 381);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fuel";
			// 
			// groupBox2
			// 
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox2.Location = new System.Drawing.Point(3, 192);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.groupBox2.Size = new System.Drawing.Size(382, 186);
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
			this.groupBox3.Location = new System.Drawing.Point(419, 35);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.groupBox3.Size = new System.Drawing.Size(649, 381);
			this.groupBox3.TabIndex = 22;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "BMI";
			this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
			// 
			// BMICalcualteButton
			// 
			this.BMICalcualteButton.Location = new System.Drawing.Point(237, 131);
			this.BMICalcualteButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.BMICalcualteButton.Name = "BMICalcualteButton";
			this.BMICalcualteButton.Size = new System.Drawing.Size(200, 37);
			this.BMICalcualteButton.TabIndex = 9;
			this.BMICalcualteButton.Text = "Calculate";
			this.BMICalcualteButton.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(159, 77);
			this.textBox3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(159, 22);
			this.textBox3.TabIndex = 8;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(159, 47);
			this.textBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(159, 22);
			this.textBox2.TabIndex = 7;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(159, 18);
			this.textBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(428, 22);
			this.textBox1.TabIndex = 6;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
			// 
			// USRadio
			// 
			this.USRadio.AutoSize = true;
			this.USRadio.ForeColor = System.Drawing.Color.Green;
			this.USRadio.Location = new System.Drawing.Point(458, 77);
			this.USRadio.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.USRadio.Name = "USRadio";
			this.USRadio.Size = new System.Drawing.Size(134, 21);
			this.USRadio.TabIndex = 5;
			this.USRadio.TabStop = true;
			this.USRadio.Text = "US unit (lb, inch)";
			this.USRadio.UseVisualStyleBackColor = true;
			// 
			// MetricRadio
			// 
			this.MetricRadio.AutoSize = true;
			this.MetricRadio.ForeColor = System.Drawing.Color.Green;
			this.MetricRadio.Location = new System.Drawing.Point(458, 48);
			this.MetricRadio.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.MetricRadio.Name = "MetricRadio";
			this.MetricRadio.Size = new System.Drawing.Size(151, 21);
			this.MetricRadio.TabIndex = 4;
			this.MetricRadio.TabStop = true;
			this.MetricRadio.Text = "Metric Unit (kg, cm)";
			this.MetricRadio.UseVisualStyleBackColor = true;
			this.MetricRadio.CheckedChanged += new System.EventHandler(this.MetricRadio_CheckedChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Location = new System.Drawing.Point(16, 185);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.groupBox4.Size = new System.Drawing.Size(621, 193);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Results for";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.ForeColor = System.Drawing.Color.Green;
			this.label11.Location = new System.Drawing.Point(30, 77);
			this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(83, 17);
			this.label11.TabIndex = 2;
			this.label11.Text = "Weight (Kg)";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.Green;
			this.label10.Location = new System.Drawing.Point(30, 48);
			this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(73, 17);
			this.label10.TabIndex = 1;
			this.label10.Text = "Hight (cm)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Green;
			this.label2.Location = new System.Drawing.Point(30, 21);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Your Name";
			this.label2.Click += new System.EventHandler(this.label2_Click_1);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1088, 771);
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
			this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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

