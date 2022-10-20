using System.Security.Policy;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Webshop.Models;

namespace Webshop.Data
{

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .Entity<ProductTypes>().HasData(
                new ProductTypes { Id = 10, ProductType = "Phones" },
                new ProductTypes { Id = 11, ProductType = "Macbooks" },
                new ProductTypes { Id = 12, ProductType = "Plants" }


                );

            builder
                .Entity<SpecialTag>().HasData(
                new SpecialTag { Id = 1, Name = "Monstera" },
                new SpecialTag { Id = 2, Name = "Iphones" },
                new SpecialTag { Id = 3, Name = "MacBook Air" },
                new SpecialTag { Id = 4, Name = "MacBook Pro" },
                new SpecialTag { Id = 5, Name = "Palm" },
                new SpecialTag { Id = 6, Name = "Thriller" },
                new SpecialTag { Id = 7, Name = "Romance" }
                );

            builder
                .Entity<Products>().HasData(
                new Products { Id = 1, Name = "Monstera deliciosa",  Price = 30, Image = "Images/monstera1.jpg", ProductColor = "green", isAvailable = true, ProductTypeId = 3, SpecialTagId = 1 },
                new Products { Id = 2, Name = "Iphone 13", Price = 1000, Image = "Images/iphone.png", ProductColor = "white", isAvailable = true, ProductTypeId = 1, SpecialTagId = 2 },
                new Products { Id = 3, Name = "Areca palm", Price = 30, Image = "Images/areca.jpg", ProductColor = "green", isAvailable=true, ProductTypeId = 3, SpecialTagId = 5},
                new Products { Id = 4, Name = "Bamboo palm", Price = 12, Image = "Images/bamboo.jpg", ProductColor = "green", isAvailable = true, ProductTypeId = 3, SpecialTagId = 5 },
                new Products { Id = 5, Name = "MacBook Pro 13", Price = 1243, Image = "Images/macbook1.png", ProductColor = "white", isAvailable = true, ProductTypeId = 2, SpecialTagId = 4 }
                );

           
        }

        public DbSet<ProductTypes> ProductTypes { get; set; }
        public DbSet<SpecialTag> SpecialTags { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Order> Orders {get; set;}
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    }

}


