using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using project5.Models;

namespace project5.Data
{
    public class project5Context : DbContext
    {
        public project5Context (DbContextOptions<project5Context> options)
            : base(options)
        {
        }

        public DbSet<project5.Models.Category> Category { get; set; }
        public DbSet<project5.Models.Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Category>().ToTable("Category");
        }
    }
}
