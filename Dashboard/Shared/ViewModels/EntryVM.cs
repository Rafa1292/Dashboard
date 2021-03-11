using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.ViewModels
{
    public class EntryVM
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int Amount { get; set; }

        public int PayMethodId { get; set; }

        public virtual PayMethodVM PayMethod { get; set; }
    }
}
