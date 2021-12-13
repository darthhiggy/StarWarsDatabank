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
    public class ArmorCategoryEntityConfiguration : IEntityTypeConfiguration<ArmorCategory>
    {
        public void Configure(EntityTypeBuilder<ArmorCategory> builder)
        {
            builder.ToTable("ArmorCategories", schema: "Items")
                .OwnsMany(p => p.Books, a =>
                {
                    a.WithOwner().HasForeignKey("ArmorCategoryId");
                    a.Property<int>("BookId");
                    a.HasKey("BookId");
                })
            .HasKey(pk => pk.EntityId);

        }
    }
}
