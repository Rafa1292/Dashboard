using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.ViewModels
{
    public class GoalVM
    {
        public int GoalId { get; set; }

        public int BudgetId { get; set; }

        public decimal ExpectedProfit { get; set; }

        public decimal TotalSale { get; set; }

        public DateTime Date { get; set; }

        public int InventorySpendingPercentage { get; set; }

        public decimal FixedExpense { get; set; }

        public virtual List<DayVM> Days { get; set; }
    }
}
