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
		private FuelConsumption fc = new FuelConsumption();
		private BMRCalculator bmr = new BMRCalculator();

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
			this.Text = "Universal Calculator";
			USRadio.Checked = true;
			heightLabel.Text = " Height (Feet)";
			weightLabel.Text = "Weight (lb)";
			norBmi.Text = string.Empty;
			label10.Text = "-1";
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
						bmr.SetHeight(outValue * 12.00);
					}
					else
					{
						bmiCalc.SetHeight(outValue / 100.0);
						bmr.SetHeight(outValue);
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
					bmiCalc.SetWeight(outValue);
					bmr.SetWeight(outValue);
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
				bmr.SetName(nameTxt.Text);
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
			bmr.SetUnitTypes(UnitTypes.Metric);
			heightLabel.Text = " Height (cm)";
			weightLabel.Text = "Weight (Kg)";
		}

		private void USRadio_CheckedChanged(object sender, EventArgs e)
		{
			bmiCalc.SetUnitType(UnitTypes.American);
			bmr.SetUnitTypes(UnitTypes.American);
			heightLabel.Text = " Height (Feet)";
			weightLabel.Text = "Weight (lb)";
		}

		private void calculateButton_Click(object sender, EventArgs e)
		{
			bool ok = ReadInputFuel();

			if (ok)
			{
				DisplayFuelResults();
			}
		}

		private void DisplayFuelResults()
		{
			fuelKmLitResult.Text = fc.KmPerLit().ToString("f2");
			fuelLitKmResult.Text = fc.LitPerKm().ToString("f2");
			fuelLitMetricResult.Text = fc.LitPerMetric().ToString("f2");
			fuelLitSweResult.Text = fc.LitPerSwe().ToString("f2");
			costperKiloResult.Text = fc.CostPerKm().ToString("f2");
		}

		private bool ReadInputFuel()
		{
			return ReadCurrent() && ReadPrevious() && ReadFuelAmount() && ReadFuelPrice();
		}

		private bool ReadCurrent()
		{
			int outValue = 0;
			bool ok = int.TryParse(currentReadingTxtBox.Text, out outValue);
			if (ok)
			{
				if (outValue > 0)
				{
					fc.SetCurrentReading(outValue);
				}
				else
					ok = false;
			}

			if (!ok)
			{
				MessageBox.Show("Invalid current Reading value!", "Error");
			}

			return ok;
		}

		private bool ReadPrevious()
		{
			int outValue = 0;
			bool ok = int.TryParse(previousReadingTxtBox.Text, out outValue);
			if (ok)
			{
				if (outValue >= 0)
				{
					fc.SetPreviousReading(outValue);
				}
				else
					ok = false;
			}

			if (!ok)
			{
				MessageBox.Show("Invalid previous Reading value!", "Error");
			}

			return ok;
		}

		private bool ReadFuelAmount()
		{
			int outValue = 0;
			bool ok = int.TryParse(currentAmountTxtBox.Text, out outValue);
			if (ok)
			{
				if (outValue > 0)
				{
					fc.SetFuelAmount(outValue);
				}
				else
					ok = false;
			}

			if (!ok)
			{
				MessageBox.Show("Invalid amount Reading value!", "Error");
			}

			return ok;
		}

		private bool ReadFuelPrice()
		{
			double outValue = 0;
			bool ok = double.TryParse(priceTxtBox.Text, out outValue);
			if (ok)
			{
				if (outValue > 0)
				{
					fc.SetFuelPrice(outValue);
				}
				else
					ok = false;
			}

			if (!ok)
			{
				MessageBox.Show("Invalid price Reading value!", "Error");
			}

			return ok;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
		}

		private void femaleRadio_CheckedChanged(object sender, EventArgs e)
		{
			bmr.SetGender(Genders.Female);
		}

		private void maleRadio_CheckedChanged(object sender, EventArgs e)
		{
			bmr.SetGender(Genders.Male);
		}

		private bool ReadAge()
		{
			int outValue = 0;
			bool ok = int.TryParse(ageTxt.Text, out outValue);
			if (ok)
			{
				if (outValue > 0)
				{
					bmr.SetAge(outValue);
				}
				else
					ok = false;
			}

			if (!ok)
			{
				MessageBox.Show("Invalid Age value!", "Error");
			}

			return ok;
		}

		private void bmrCalcButton_Click(object sender, EventArgs e)
		{
			bool ok = ReadInputBMR();

			if (ok)
			{
				DisplayBMRResults();
			}
		}

		private void DisplayBMRResults()
		{
			string str = bmr.MaintainCurrentWeight().ToString("f2");
			listBox1.Items.Add("BMR Results for" + bmr.GetName());
			listBox1.Items.Add("Your BMR(calories/day)" + bmr.CalculateBMR());
			listBox1.Items.Add("Calories to maintain your weight" + bmr.MaintainCurrentWeight().ToString("f2"));
		}


		private bool ReadInputBMR()
		{
			ReadName();
			return ReadAge() && ReadHeight() && ReadWeight();
		}




		private void extraActive_CheckedChanged(object sender, EventArgs e)
		{
			bmr.SetActivity(ActivityLevels.ExtraActive);
		}

		private void VeryActive_CheckedChanged(object sender, EventArgs e)
		{
			bmr.SetActivity(ActivityLevels.VeryActive);
		}

		private void moderatelyActive_CheckedChanged(object sender, EventArgs e)
		{
			bmr.SetActivity(ActivityLevels.ModeratelyActive);
		}

		private void lightlyActive_CheckedChanged(object sender, EventArgs e)
		{
			bmr.SetActivity(ActivityLevels.LightlyActive);
		}

		private void sedentary_CheckedChanged(object sender, EventArgs e)
		{
			bmr.SetActivity(ActivityLevels.Sedentary);
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			label10.Text = listBox1.SelectedIndex.ToString();
		}

		private void unselectButton_Click(object sender, EventArgs e)
		{
			listBox1.ClearSelected();
			
		}
	}
}