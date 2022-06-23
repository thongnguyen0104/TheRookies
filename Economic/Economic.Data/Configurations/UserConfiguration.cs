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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Email).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Phone).IsRequired(false).HasMaxLength(11);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Address).IsRequired(false).HasMaxLength(100);

            builder.Property(p => p.Avatar).HasDefaultValue("default-avatar.png");
        }
    }
}
