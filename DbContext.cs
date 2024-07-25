using Microsoft.EntityFrameworkCore;

namespace _;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Usuario> Usuario { get; set; }
}