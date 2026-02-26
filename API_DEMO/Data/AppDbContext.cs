using Microsoft.EntityFrameworkCore;
using API_DEMO.Models;

namespace API_DEMO.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Users> Users => Set<Users>();
}