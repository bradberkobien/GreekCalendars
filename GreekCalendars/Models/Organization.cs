using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreekCalendars.Models
{
    public class Organization
    {
        public int OrganizationID { get; set; }
        public string OrganizationName { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}