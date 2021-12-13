using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.GearAndEquipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.FFG.Data.Configuration.Items
{
    public class GearCategoryEntityConfiguration : IEntityTypeConfiguration<GearCategory>
    {
        public void Configure(EntityTypeBuilder<GearCategory> builder)
        {
            builder.ToTable("GearCategories", schema: "Items")
            .OwnsMany(p => p.Books, a =>
            {
                a.WithOwner().HasForeignKey("GearCategoryId");
                a.Property<int>("BookId");
                a.HasKey("BookId");
            })
            .HasKey(k => k.EntityId);
        }
    }
}
