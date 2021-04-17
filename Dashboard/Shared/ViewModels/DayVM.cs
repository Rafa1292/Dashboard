using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.ViewModels
{
    public class DayVM
    {
        public int DayId { get; set; }

        public string Name { get; set; }

        public bool Open { get; set; }

        public decimal Goal { get; set; }

        public DateTime Date { get; set; }

        public int DaysBefore { get; set; }

        public int DaysAfter { get; set; }


    }
}
