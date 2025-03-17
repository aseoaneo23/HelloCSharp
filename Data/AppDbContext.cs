using Microsoft.EntityFrameworkCore;
using ProductsApi.Configuration;
using ProductsApi.Models;

namespace ProductsApi.Data;


public class AppDbContext : DbContext
{
    public readonly AppSettings _appSettings;
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer();
    }
}