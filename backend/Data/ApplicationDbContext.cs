using Microsoft.EntityFrameworkCore;
using backend.Models;

public class ApplicationDbContext : DbContext
{
    public DbSet<Race> Races { get; set; }
    public DbSet<PitStop> PitStops { get; set; }
    // Add other tables (Driver, Circuit, etc.)

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseNpgsql("Host=localhost;Database=f1;Username=postgres;Password=yourpassword");
}