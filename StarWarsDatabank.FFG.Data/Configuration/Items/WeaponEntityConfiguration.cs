using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarWarsDatabank.Framework.Enums;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.FFG.Data.Configuration.Items
{
    public class WeaponEntityConfiguration : IEntityTypeConfiguration<Weapon>
    {
        public void Configure(EntityTypeBuilder<Weapon> builder)
        {
            builder.ToTable("Weapons", schema: "Items")
            .OwnsMany(p => p.Books, a =>
            {
                a.WithOwner().HasForeignKey("WeaponId");
                a.Property<int>("BookId");
                a.HasKey("BookId");
            })
            .HasKey(pk => pk.AggregateId);

            builder.Property(p => p.Range)
                .HasConversion(new EnumToStringConverter<RangeBands>());

            builder.HasMany(b => b.Qualities)
                .WithMany(b => b.Weapons)
                .UsingEntity(j => j.ToTable("WeaponWeaponQuality"));
        }
    }
}
