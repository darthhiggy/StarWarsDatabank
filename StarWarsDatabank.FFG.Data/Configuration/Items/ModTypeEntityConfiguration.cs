using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Mods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.FFG.Data.Configuration.Items
{
    public class ModTypeEntityConfiguration : IEntityTypeConfiguration<ModType>
    {
        public void Configure(EntityTypeBuilder<ModType> builder)
        {
            builder.ToTable("ModTypes", schema: "Items")
                .OwnsMany(p => p.Books, a =>
                {
                    a.WithOwner().HasForeignKey("ModTypesId");
                    a.Property<int>("BookId");
                    a.HasKey("BookId");
                })
                .HasKey(pk => pk.EntityId);
        }
    }
}
