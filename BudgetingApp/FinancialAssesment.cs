using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BudgetingApp
{
    // The FinancialAssessment class represents a form used to gather financial information
    // from the user, such as income and savings goals, and display them on a FinancialChart form.
    public partial class FinancialAssessment : Form
    {

        public FinancialAssessment()
        {
            InitializeComponent();

            // Set the userNameLabel to display the user's email address from the SignUp form.
            userNameLabel.Text = SignUp.Email;
        }

        // Event handler for the label3 control's Click event.
        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Event handler for the userNameLabel control's Click event.
        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        // Event handler for the FinancialAssessment form's Load event.
        private void FinancialAssessment_Load(object sender, EventArgs e)
        {

        }

        // The income variable holds the user's income.
        public static int income = 0;
        // Event handler for the incomeTextBox control's TextChanged event.
        private void incomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // The savedMoney variable holds the user's savings.
        public static int savedMoney = 0;
        // Event handler for the savedTextBox control's TextChanged event.
        private void savedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Event handler for the submitButton control's Click event.
        private void submitButton_Click(object sender, EventArgs e)
        {
            // Parse the income and savedMoney values from their respective text boxes.
            income = int.Parse(incomeTextBox.Text.ToString());
            savedMoney = int.Parse(savedTextBox.Text.ToString());

            // Hide the FinancialAssessment form and display the FinancialChart form.
            this.Hide();
            FinancialChart f3 = new FinancialChart();
            f3.Show();
        }

        // The generalSaving variable holds the user's goal to save money generally.
        public static bool generalSaving = false;
        // Event handler for the saveMoneyGeneralCheckBox control's CheckedChanged event.
        private void saveMoneyGeneralCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        // The eraseDebt variable holds the user's goal to erase debt.
        public static bool eraseDebt = false;
        // Event handler for the eraseDebtCheckBox control's CheckedChanged event.
        private void eraseDebtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Update the eraseDebt variable to match the state of the eraseDebtCheckBox.
            eraseDebt = eraseDebtCheckBox.Checked;
        }

        // The retirementSaving variable holds the user's goal to save for retirement.
        public static bool retirementSaving = false;
        // Event handler for the saveRetirementCheckBox control's CheckedChanged event.
        private void saveRetirementCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Update the retirementSaving variable to match the state of the saveRetirementCheckBox.
            retirementSaving |= saveRetirementCheckBox.Checked;
        }

        // The collegeSaving variable holds the user's goal to save for college.
        public static bool collegeSaving = false;
        // Event handler for the saveCollegeCheckBox control's CheckedChanged event.
        private void saveCollegeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Update the collegeSaving variable to match the state of the saveCollegeCheckBox.
            collegeSaving = saveCollegeCheckBox.Checked;
        }

        // The personalLearning variable holds the user's goal to save for personal learning.
        public static bool personalLearning = false;
        private void personalLearningCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Update the personalLearning variable to match the state of the personalLearningCheckBox.
            personalLearning = personalLearningCheckBox.Checked;
        }

        // The purchaseSaving variable holds the user's goal to save for a purchase.
        public static bool purchaseSaving = false;
        private void forPurchaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Update the purchaseSaving variable to match the state of the forPurchaseCheckBox.
            purchaseSaving = forPurchaseCheckBox.Checked;
        }

        // The otherSaving variable holds the user's goal to save for other (misc).
        public static bool otherSaving = false;
        private void otherCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Update the otherSaving variable to match the state of the otherCheckBox.
            otherSaving = otherCheckBox.Checked;
        }
    }
}
