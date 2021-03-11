using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.ViewModels
{
    public class WorkDayVM
    {
        public int Id { get; set; }

        public int TotalSales { get; set; }

        public int TotalCard { get; set; }

        public int TotalSinpe { get; set; }

        public int TotalTransfer { get; set; }

        public virtual List<DebitVM> Debits { get; set; }

        public virtual List<EntryVM> Entries { get; set; }

        public virtual List<CreditVM> Credits { get; set; }

    }
}
