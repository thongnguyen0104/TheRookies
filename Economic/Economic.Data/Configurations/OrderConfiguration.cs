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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.OrderDate).IsRequired();
            builder.Property(x => x.DeliveryDate).IsRequired(false);
            builder.Property(x => x.Address).IsRequired(false);
            builder.Property(x => x.Phone).IsRequired(false);
        }
    }
}
