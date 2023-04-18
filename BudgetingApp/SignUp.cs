using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetingApp
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Define a static string variable to store the email entered by the user
        public static String Email;

        private void signUpButton_Click(object sender, EventArgs e)
        {
            // Store the email entered by the user in the Email variable
            Email = emailTextBox.Text.ToString();

            // Hide the current form and show the next form (FinancialAssessment)
            this.Hide();
            FinancialAssessment f2 = new FinancialAssessment();
            f2.Show();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            // Make password characters unreadable
            passwordTextBox.PasswordChar = '*';
        }
    }
}