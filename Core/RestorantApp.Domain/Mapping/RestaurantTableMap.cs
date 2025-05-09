using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestorantApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantApp.Domain.Mapping
{
    public class RestaurantTableMap : IEntityTypeConfiguration<RestaurantTable>
    {
        public void Configure(EntityTypeBuilder<RestaurantTable> builder)
        {
            builder.HasKey(rt => rt.Id);
            builder.Property(rt => rt.TableNumber).IsRequired();
            builder.Property(rt => rt.Capacity).IsRequired();

            /*builder.HasMany(rt => rt.Reservations)
                .WithOne(r => r.RestaurantTable)
                .HasForeignKey(r => r.RestaurantTableId)
                .OnDelete(DeleteBehavior.Cascade);*/

        }
    }
}
