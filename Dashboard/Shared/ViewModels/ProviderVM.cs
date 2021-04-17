using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.ViewModels
{
    public class ProviderVM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Phone { get; set; }

        public bool FixedExpense { get; set; }
    }
}
