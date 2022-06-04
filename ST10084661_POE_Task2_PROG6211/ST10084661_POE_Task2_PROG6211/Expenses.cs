using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084661_POE_Task2_PROG6211
{
    abstract class Expenses
    {
        //expense list
        public static List<double> ExpensesList = new List<double>();

        //global variables
        public double totalExpenses;
        public static double housePayment;

        //method --> get total expenses
        public double getTotalExpense()
        {
            //gets total from list
            totalExpenses = ExpensesList.Sum();

            return totalExpenses;
        }

        //abstract method that is overriden with either homeloan or rent
        public abstract void monthlyRepayments();
    }
}
