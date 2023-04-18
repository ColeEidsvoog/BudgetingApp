using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudgetingApp
{
    internal class Expense
    {
        // The Name property represents the name of the expense.
        public string Name { get; set; }

        // The Cost property represents the cost of the expense.
        public int Cost { get; set; }

        // The Type property represents the type of the expense.
        public string Type { get; set; }

        // The constructor for the Expense class. This method is called when a new
        // Expense object is created.
        public Expense(string name, int cost, string type)
        {
            // Assign the provided name to the Name property.
            Name = name;

            // Assign the provided cost to the Cost property.
            Cost = cost;

            // Assign the provided type to the Type property.
            Type = type;
        }

        public static List<Expense> totalExpenses = new List<Expense>();


    }
}