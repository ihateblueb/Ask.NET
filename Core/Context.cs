using Microsoft.EntityFrameworkCore;

namespace Ask.NET.Core;

public class Context : DbContext
{
    // writing Models here may seem silly but it makes the chance of writing Ask wrong less
    public DbSet<Models.Ask> Asks { get; set; }
    public DbSet<Models.Auth> Auths { get; set; }
    public DbSet<Models.SyncMethod> SyncMethods { get; set; }
    public DbSet<Models.User> Users { get; set; }

    private string connectionString = "";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(connectionString);
}