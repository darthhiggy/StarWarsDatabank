
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarWarsDatabank.FFG.Data.Configuration.Items;
using StarWarsDatabank.FFG.Data.Configuration.Skills;
using StarWarsDatabank.FFG.Data.Configuration.Talents;
using StarWarsDatabank.Framework;
using StarWarsDatabank.Framework.Enums;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Armor;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.GearAndEquipment;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Mods;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Weapons;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.CombatSkills;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.GeneralSkills;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.KnowledgeSkills;
using StarWarsDatabank.Talents.FFG.Domain.AggregatesModel;

namespace StarWarsDatabank.FFG.Data;
public class FFGDatabankContext : DbContext
{
    public DbSet<GameVersion> GameVersions { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<CombatSkill> CombatSkills { get; set; }
    public DbSet<GeneralSkill> GeneralSkills { get; set; }
    public DbSet<KnowledgeSkill> KnowledgeSkills { get; set; }
    public DbSet<GearCategory> GearCategories { get; set; }
    public DbSet<Gear> Gear { get; set; }
    public DbSet<WeaponCategory> WeaponCategories { get; set; }
    public DbSet<WeaponQuality> WeaponQualities { get; set; }
    public DbSet<Weapon> Weapons { get; set; }
    public DbSet<ArmorCategory> ArmorCategories { get; set; }
    public DbSet<ArmorQuality> ArmorQualities { get; set; }
    public DbSet<Armor> Armors { get; set; }
    public DbSet<Mod> Mods { get; set; }
    public DbSet<ModType> ModTypes { get; set; }
    public DbSet<Talent> Talents { get; set; }
    public DbSet<TalentActivation> TalentActivations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(
            "Server = (localdb)\\mssqllocaldb; Database = StarWarsDatabank; Trusted_Connection = True; ")
                 .EnableSensitiveDataLogging(true);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Book>().ToTable("Books", schema: "Books");
        modelBuilder.Entity<GameVersion>().ToTable("GamerVersions", schema: "Books");

        modelBuilder.ApplyConfiguration(new GearEntityConfiguration());
        modelBuilder.ApplyConfiguration(new GearCategoryEntityConfiguration());
            
        modelBuilder.ApplyConfiguration(new CombatSkillEntityConfiguration());
        modelBuilder.ApplyConfiguration(new GeneralSkillEntityConfiguration());
        modelBuilder.ApplyConfiguration(new KnowledgeSkillEntityConfiguration());

        modelBuilder.ApplyConfiguration(new WeaponCategoryEntityConfiguration());
        modelBuilder.ApplyConfiguration(new WeaponQualityEntityConfiguration());
        modelBuilder.ApplyConfiguration(new WeaponEntityConfiguration());

        modelBuilder.ApplyConfiguration(new ArmorCategoryEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ArmorQualityEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ArmorEntityConfiguration());

        modelBuilder.ApplyConfiguration(new ModTypeEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ModEntityConfiguration());

        modelBuilder.ApplyConfiguration(new TalentActivationEntityConfiguration());
        modelBuilder.ApplyConfiguration(new TalentEntityConfiguration());
    }
}
