using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappings
{
    public class EventMapConfig  : EntityTypeConfiguration<Event>
    {
        public EventMapConfig()
        {
            this.ToTable("EVENT");
            this.Property(p => p.Name).HasMaxLength(40).IsRequired();
            this.Property(p => p.Date).IsRequired();
        }
    }

}
