using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarWarsDatabank.Talents.FFG.Domain.AggregatesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.FFG.Data.Configuration.Talents
{
    public class TalentEntityConfiguration : IEntityTypeConfiguration<Talent>
    {
        public void Configure(EntityTypeBuilder<Talent> builder)
        {
            builder.ToTable("Talents", schema: "Talent").OwnsMany(p => p.Books, a =>
            {
                a.WithOwner().HasForeignKey("TalentActivationId");
                a.Property<int>("BookId");
                a.HasKey("BookId");
            })
            .HasKey(pk => pk.AggregateId);
        }
    }
}
