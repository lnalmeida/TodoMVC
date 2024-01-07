using Microsoft.EntityFrameworkCore;
using TodoMVC.Models;
using TodoMVC.Models.EntityConfig;

namespace TodoMVC.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<Todo> Todos => Set<Todo>();

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer("Data Source=127.0.0.1,1445;User ID=SA;Password=s3nh4!@#$;Database=db_Todo; Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new TodoEntityConfig());
    }
}
