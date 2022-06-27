using Economic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Address).IsRequired(false).HasMaxLength(100);
            builder.Property(p => p.Avatar).HasDefaultValue("default-avatar.png");
            //builder.Property(x => x.RegisteredDate).IsRequired();
        }
    }
}
