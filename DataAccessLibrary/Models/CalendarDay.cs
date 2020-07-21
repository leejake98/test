using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public  class CalendarDay
    {
        public int DayNumber { get; set; }
        public DateTime Date { get; set; }
        public bool IsLastMonth { get; set; } = false;

        public bool IsNextMonth { get; set; } = false;

        public bool IsEventDay { get; set; } = false;

        public int NextroundIRNumber { get; set; }


        //public List<CalendarEvent> Events { get; set; }c

    }
}
