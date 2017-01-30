using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GreekCalendars.Models;

namespace GreekCalendars.DAL
{
    public class GreekCalendarInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GreekCalendarContext>
    {
        protected override void Seed(GreekCalendarContext context)
        {
            var events = new List<Event>
            {
                new Event{EventName="Volleyball",Summary="Hit the ball with your arms and stuff",EventStartDateTime=DateTime.Parse("2016-09-01")},
                new Event{EventName="Basketball",EventStartDateTime=DateTime.Parse("2016-09-01")}
            };

            events.ForEach(e => context.Events.Add(e));
            context.SaveChanges();

            var organizations = new List<Organization>
            {
                 new Organization{OrganizationName="Fake Fraternity"}
            };

            organizations.ForEach(o => context.Organizations.Add(o));
            context.SaveChanges();
        }
    }
}