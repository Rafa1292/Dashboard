using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.ViewModels
{
    public class DirectionVM
    {
        public int Id { get; set; }

        public string Direction { get; set; }

        public int WorkerId { get; set; }

        public WorkerVM Worker { get; set; }
    }
}
