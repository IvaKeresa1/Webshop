using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;
using Webshop.Models;

namespace Ispit.Data.Models;

public class ProductContext : DbContext
{
    public ProductContext(DbContextOptions<ProductContext> options)
    : base(options)
    {
    }

    public DbSet<Products> Products { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(
            "Data Source = localhost; Initial Catalog = master; UID = SA; PWD = reallyStrongPwd123; Integrated Security = false; Encrypt=false"
            );
        }
    }
}

