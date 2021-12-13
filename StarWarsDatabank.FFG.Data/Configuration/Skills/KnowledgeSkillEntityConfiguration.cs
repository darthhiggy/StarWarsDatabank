using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarWarsDatabank.Framework.Enums;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.KnowledgeSkills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.FFG.Data.Configuration.Skills
{
    public class KnowledgeSkillEntityConfiguration : IEntityTypeConfiguration<KnowledgeSkill>
    {
        public void Configure(EntityTypeBuilder<KnowledgeSkill> builder)
        {
            builder.ToTable("KnowledgeSkills", schema: "Skills")
            .OwnsMany(p => p.Books, a =>
            {
                a.WithOwner().HasForeignKey("KnowledgeSkillId");
                a.Property<int>("BookId");
                a.HasKey("BookId");
            })
            .HasKey(k => k.AggregateId);

            builder.Property(p => p.Characteristic)
                .HasConversion(new EnumToStringConverter<Ability>());
        }
    }
}
