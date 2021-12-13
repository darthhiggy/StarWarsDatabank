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
    public class ArmorEntityConfiguration : IEntityTypeConfiguration<Armor>
    {
        public void Configure(EntityTypeBuilder<Armor> builder)
        {
            builder.ToTable("Armor", schema: "Items")
            .OwnsMany(p => p.Books, a =>
            {
                a.WithOwner().HasForeignKey("ArmorId");
                a.Property<int>("BookId");
                a.HasKey("BookId");
            })
            .HasKey(pk => pk.AggregateId);

            builder.HasMany(a => a.Qualities)
                .WithMany(a => a.Armors)
                .UsingEntity(j => j.ToTable("ArmorArmorQualities"));
        }
    }
}
