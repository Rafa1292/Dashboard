using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.ViewModels
{
    public class DebitVM
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int Amount { get; set; }

        public int DebitTypeId { get; set; }

        public virtual DebitTypeVM DebitType { get; set; }

        public int PayMethodId { get; set; }

        public virtual PayMethodVM PayMethod { get; set; }

        public int ProviderId { get; set; }

        public virtual ProviderVM Provider { get; set; }

        public int WorkerId { get; set; }

        public virtual WorkerVM Worker { get; set; }
    }
}
