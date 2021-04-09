using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.ViewModels
{
    public class CashMoves
    {
        public int Amount { get; set; }

        public string Description { get; set; }

        public int TicketNumber { get; set; }

        public virtual CustomerVM Customer { get; set; }

        public virtual ProviderVM Provider { get; set; }

        public virtual WorkerVM Worker { get; set; }

        public virtual PayMethodVM PayMethod { get; set; }

        public virtual DebitTypeVM DebitType { get; set; }


    }
}
