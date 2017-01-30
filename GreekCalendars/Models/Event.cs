using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreekCalendars.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public DateTime EventStartDateTime { get; set; }
    }
}