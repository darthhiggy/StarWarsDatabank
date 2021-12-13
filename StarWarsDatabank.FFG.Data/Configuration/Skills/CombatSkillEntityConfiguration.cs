using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarWarsDatabank.Framework.Enums;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.CombatSkills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.FFG.Data.Configuration.Skills
{
    public class CombatSkillEntityConfiguration : IEntityTypeConfiguration<CombatSkill>
    {
        public void Configure(EntityTypeBuilder<CombatSkill> builder)
        {
            builder.ToTable("CombatSkills", schema: "Skills")
            .OwnsMany(p => p.Books, a =>
            {
                a.WithOwner().HasForeignKey("CombatSkillId");
                a.Property<int>("BookId");
                a.HasKey("BookId");
            })
            .HasKey(k => k.AggregateId);

            builder.Property(p => p.Characteristic)
                .HasConversion(new EnumToStringConverter<Ability>());
        }
    }
}
