using GreekCalendars.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace GreekCalendars.DAL
{
    public class GreekCalendarContext : DbContext
    {
        public GreekCalendarContext() : base("GreekCalendarContext")
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Organization> Organizations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }

}