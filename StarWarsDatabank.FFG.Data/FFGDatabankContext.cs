
using Microsoft.EntityFrameworkCore;
using StarWarsDatabank.Framework;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.GearAndEquipment;

namespace StarWarsDatabank.FFG.Data;
public class FFGDatabankContext : DbContext
{
    public DbSet<GameVersion> GameVersions { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<GearCategory> GearCategories {get;set;}
    public DbSet<Gear> Gear { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(
            "Server = (localdb)\\mssqllocaldb; Database = StarWarsDatabank; Trusted_Connection = True; ")
                 .EnableSensitiveDataLogging(true);
    }
}
