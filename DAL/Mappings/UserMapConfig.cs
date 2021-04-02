using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappings
{
    public class UserMapConfig : EntityTypeConfiguration<User>
    {

        public UserMapConfig()
        {
            this.ToTable("USER");
            this.Property(p => p.Name).HasMaxLength(70).IsRequired();
            this.Property(p => p.Password).HasMaxLength(10).IsRequired();
        }

    }
}
