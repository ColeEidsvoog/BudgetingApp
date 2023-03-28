using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace BudgetingApp
{
    public partial class FinancialChart : Form
    {
        public FinancialChart()
        {
            InitializeComponent();
        }

        private void FinancialChart_Load(object sender, EventArgs e)
        {

        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            // Hide current form and show the Report form
            this.Hide();
            Report f4 = new Report();
            f4.Show();
        }

        private void submitExpenseButton_Click(object sender, EventArgs e)
        {
            // Get the value of the new slice from the cost text box
            double newValue = double.Parse(costTextBox.Text);

            string selectedOption = "";
            // Check which radio button is selected
            if (housingRadioButton.Checked)
            {
                selectedOption = housingRadioButton.Text;
                housingRadioButton.Checked = false;
            }
            else if (utilityRadioButton.Checked)
            {
                selectedOption = utilityRadioButton.Text;
                utilityRadioButton.Checked = false;
            }
            else if (transportationRadioButton.Checked)
            {
                selectedOption = transportationRadioButton.Text;
                transportationRadioButton.Checked = false;
            }
            else if (foodRadioButton.Checked)
            {
                selectedOption = foodRadioButton.Text;
                foodRadioButton.Checked = false;
            }
            else if (healthcareRadioButton.Checked)
            {
                selectedOption = healthcareRadioButton.Text;
                healthcareRadioButton.Checked = false;
            }
            else if (personalCareRadioButton.Checked)
            {
                selectedOption = personalCareRadioButton.Text;
                personalCareRadioButton.Checked = false;
            }
            else if (entertainmentRadioButton.Checked)
            {
                selectedOption = entertainmentRadioButton.Text;
                entertainmentRadioButton.Checked = false;
            }
            else if (debtPaymentsRadioButton.Checked)
            {
                selectedOption = debtPaymentsRadioButton.Text;
                debtPaymentsRadioButton.Checked = false;
            }
            else if (childcareRadioButton.Checked)
            {
                selectedOption = childcareRadioButton.Text;
                childcareRadioButton.Checked = false;
            }
            else if (clothingRadioButton.Checked)
            {
                selectedOption = clothingRadioButton.Text;
                clothingRadioButton.Checked = false;
            }
            else if (otherRadioButton.Checked)
            {
                selectedOption = otherRadioButton.Text;
                otherRadioButton.Checked = false;
            }

            // Add a new data point to the chart series
            budgetLayoutChart.Series[1].Points.AddXY(selectedOption, newValue);

            // Clear the text boxes and reset the new value to 0
            costTextBox.Text = "";
            nameTextBox.Text = "";
            newValue = 0;
        }

    }
}
