using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.ViewModels
{
    public class WorkDayVM
    {
        public int Id { get; set; }

        public int Missing { get; set; }

        public int FinalCash { get; set; }

        public int InitialCash { get; set; }

        public int TotalSales { get; set; }

        public int TotalCard { get; set; }

        public int TotalSinpe { get; set; }

        public int TotalTransfer { get; set; }

        public bool Approve { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime CloseDay { get; set; }

        public virtual GoalVM Goal { get; set; }

        public virtual List<DebitVM> Debits { get; set; }

        public virtual List<EntryVM> Entries { get; set; }

        public virtual List<CreditVM> Credits { get; set; }

    }
}
