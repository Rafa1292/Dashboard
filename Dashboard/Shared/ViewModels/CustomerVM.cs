using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.ViewModels
{
    public class CustomerVM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Phone { get; set; }

        public int MaxAmount { get; set; }

        public virtual List<DirectionVM> Directions { get; set; }
    }
}
