using Microsoft.EntityFrameworkCore;
using TodoMVC.Models;
using TodoMVC.Models.EntityConfig;

namespace TodoMVC.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) {}
    public DbSet<Todo> Todos => Set<Todo>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new TodoEntityConfig());
    }
}
