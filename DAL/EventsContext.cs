using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EventsContext : DbContext 
    {
        public EventsContext() : base("EventDB")
        {
            Database.SetInitializer(new EventDBStrategy());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }


        public class EventDBStrategy : DropCreateDatabaseIfModelChanges<EventsContext>
        {

        }
    }
}
