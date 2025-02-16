using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Ask.NET.Core;

public class Context : DbContext
{
    private static readonly IOptions<Config> config;

    // writing Models here may seem silly, but it makes the chance of writing Ask wrong less
    public DbSet<Models.Ask> Asks { get; set; }
    public DbSet<Models.Auth> Auths { get; set; }
    public DbSet<Models.SyncMethod> SyncMethods { get; set; }
    public DbSet<Models.User> Users { get; set; }

    public Context(DbContextOptions<Context> options) : base(options)
    {
    }
}