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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();

            userLabel.Text = SignUp.Email;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // Sort the expenses by expense type
            var sortedExpenses = Expense.totalExpenses.OrderBy(expense => expense.Type);

            // Display the sorted expenses in the reportListBox
            foreach (Expense expense in sortedExpenses)
            {
                string displayString = $"{expense.Name}: ${expense.Cost} ({expense.Type})";
                reportListBox.Items.Add(displayString);
            }

            // Adding expenses to the pie chart
            var groupedExpenses = from expense in Expense.totalExpenses group expense by expense.Type into expenseGroup select new { Type = expenseGroup.Key, TotalCost = expenseGroup.Sum(expense => expense.Cost) };
            financialChart.DataSource = groupedExpenses;
            financialChart.Series[0].XValueMember = "Type";
            financialChart.Series[0].YValueMembers = "TotalCost";
            financialChart.DataBind();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Makes sure to kill the process so I dont have to void it in task manager
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void mostMoneyLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
