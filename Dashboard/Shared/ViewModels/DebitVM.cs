using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.ViewModels
{
    public class DebitVM : CashMoves
    {
        public int Id { get; set; }

        public int DebitTypeId { get; set; }


        public int PayMethodId { get; set; }


        public int ProviderId { get; set; }


        public int WorkerId { get; set; }

    }
}
