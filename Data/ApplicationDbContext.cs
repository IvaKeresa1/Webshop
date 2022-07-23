﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;
using Webshop.Models;

namespace Webshop.Data
{

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProductTypes> ProductTypes { get; set; }
        public DbSet<SpecialTag> SpecialTags { get; set; }
    }

}