using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public  class CalendarMonth
    {
        public int MonthNumber { get; set; }
        public bool IsThisMonth { get; set; } = false;

        public string MonthName { get; set; }
    }
}
