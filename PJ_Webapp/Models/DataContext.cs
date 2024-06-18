using Microsoft.EntityFrameworkCore;

namespace PJ_Webapp.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<Soldier> soldiers { get; set; }
    public DbSet<Skill> skills { get; set; }
    
    public DbSet<Resource> resources { get; set; }
    
    public DbSet<User> users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Soldier>()
            .HasMany(s => s.skills)
            .WithOne(s => s.soldier)
            .HasForeignKey(s => s.soldierId);

        modelBuilder.Entity<User>()
            .HasMany(u => u.soldiers)
            .WithOne(s => s.playerOwned)
            .HasForeignKey(s => s.playerId);
    }
}