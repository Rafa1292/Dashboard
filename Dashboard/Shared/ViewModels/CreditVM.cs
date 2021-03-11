using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.ViewModels
{
    public class CreditVM
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int TicketNumber { get; set; }

        public int Amount { get; set; }

        public string Description { get; set; }

        public virtual CustomerVM Customer { get; set; }
    }
}
