using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Armor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.FFG.Data.Configuration.Items
{
    public class ArmorQualityEntityConfiguration : IEntityTypeConfiguration<ArmorQuality>
    {
        public void Configure(EntityTypeBuilder<ArmorQuality> builder)
        {
            builder.ToTable("ArmorQualities", schema: "Items")
                .OwnsMany(p => p.Books, a =>
                {
                    a.WithOwner().HasForeignKey("ArmorQualityId");
                    a.Property<int>("BookId");
                    a.HasKey("BookId");
                })
            .HasKey(pk => pk.EntityId);
        }
    }
}
