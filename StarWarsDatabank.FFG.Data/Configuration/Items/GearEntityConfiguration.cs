using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.GearAndEquipment;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StarWarsDatabank.FFG.Data.Configuration.Items
{
    public class GearEntityConfiguration : IEntityTypeConfiguration<Gear>
    {
        public void Configure(EntityTypeBuilder<Gear> builder)
        {
            builder.ToTable("Gear", schema: "Items")
            .OwnsMany(p => p.Books, a =>
            {
                a.WithOwner().HasForeignKey("GearId");
                a.Property<int>("BookId");
                a.HasKey("BookId");
            })
            .HasKey(k => k.AggregateId);
        }
    }
}
