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
    public class TalentActivationEntityConfiguration : IEntityTypeConfiguration<TalentActivation>
    {
        public void Configure(EntityTypeBuilder<TalentActivation> builder)
        {
            builder.ToTable("TalentActivations", schema: "Talent").OwnsMany(p => p.Books, a =>
            {
                a.WithOwner().HasForeignKey("TalentActivationId");
                a.Property<int>("BookId");
                a.HasKey("BookId");
            })
            .HasKey(pk => pk.EntityId); 

        }
    }
}
