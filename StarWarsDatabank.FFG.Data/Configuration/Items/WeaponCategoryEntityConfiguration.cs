using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.FFG.Data.Configuration.Items
{
    class WeaponCategoryEntityConfiguration : IEntityTypeConfiguration<WeaponCategory>
    {
        public void Configure(EntityTypeBuilder<WeaponCategory> builder)
        {
            builder.ToTable("WeaponCategories", schema: "Items")
           .OwnsMany(p => p.Books, a =>
           {
               a.WithOwner().HasForeignKey("WeaponCategoryId");
               a.Property<int>("BookId");
               a.HasKey("BookId");
           })
           .HasKey(pk => pk.EntityId);
        }
    }
}
