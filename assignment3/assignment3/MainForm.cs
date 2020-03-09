using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3
{
	
	public partial class MainForm : Form
	{
		private BMICalculator bmiCalc = new BMICalculator();
		public MainForm()
		{
			InitializeComponent();
			InitializeGUI();
		}

		private void InitializeGUI()
		{
			bmiResultsLabel.Text = string.Empty;
			categoryLabel.Text = string.Empty;
			fuelKmLitResult.Text = string.Empty;
			fuelLitKmResult.Text = string.Empty;
			fuelLitMetricResult.Text = string.Empty;
			fuelLitSweResult.Text = string.Empty;
			costperKiloResult.Text = string.Empty;
			this.Text = "Assignment 2 VG";
			USRadio.Checked = true;
			heightLabel.Text = " Height (Feet)";
			weightLabel.Text = "Weight (lb)";
			norBmi.Text = string.Empty;



		}

		private bool ReadHeight()
		{

			double outValue = 0;
			bool ok = double.TryParse(heightTxt.Text, out outValue);
			if (ok)
			{
				if (outValue > 0)
				{
					if (bmiCalc.GetUnitType() == UnitTypes.American)
					{
						bmiCalc.SetHeight(outValue * 12.00);
					}
					else
					{
						bmiCalc.SetHeight(outValue / 100.0);
					}
				}
				else
					ok = false;
			}

			if (!ok)
			{
				MessageBox.Show("invalid height value!", "Error");

			}
			return ok;
		}

		private bool ReadWeight()
		{

			double outValue = 0;
			bool ok = double.TryParse(weightTxt.Text, out outValue);
			if (ok)
			{
				if (outValue > 0)
				{
					if (bmiCalc.GetUnitType() == UnitTypes.American)
					{
						bmiCalc.SetWeight(outValue);
					}
					else
					{
						bmiCalc.SetWeight(outValue);
					}
				}
				else
					ok = false;
			}

			if (!ok)
			{
				MessageBox.Show("Invalid weight value!", "Error");

			}
			return ok;
		}

		private bool ReadInputBMI()
		{
			ReadName();
			return ReadHeight() && ReadWeight();
		}

		private void ReadName()
		{
			nameTxt.Text.Trim();
			if (!string.IsNullOrEmpty(nameTxt.Text))
			{
				bmiCalc.SetName(nameTxt.Text);
			}
			
		}

		private void DisplayResults()
		{
			bmiResultsLabel.Text = bmiCalc.CalculateBmi().ToString("f2");
			categoryLabel.Text = bmiCalc.BmiWeightCategory().ToString();
			nameLabel.Text = bmiCalc.GetName();
			norBmi.Text = " Normal BMI is between 18.5 and 24.9";
		}


		private void BMICalcualteButton_Click(object sender, EventArgs e)
		{
			bool ok = ReadInputBMI();

			if (ok)
			{
				DisplayResults();
			}
		}

		private void MetricRadio_CheckedChanged(object sender, EventArgs e)
		{
			bmiCalc.SetUnitType(UnitTypes.Metric);
			heightLabel.Text = " Height (cm)";
			weightLabel.Text = "Weight (Kg)";
		}

		private void USRadio_CheckedChanged(object sender, EventArgs e)
		{
			bmiCalc.SetUnitType(UnitTypes.American);
			heightLabel.Text = " Height (Feet)";
			weightLabel.Text = "Weight (lb)";
		}
	}
}
