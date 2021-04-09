using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.DTOs
{
    public class CalendarDayDTO
    {
        public string Name { get; set; }

        public int DaysBefore { get; set; }

        public int DaysAfter { get; set; }


    }
}
