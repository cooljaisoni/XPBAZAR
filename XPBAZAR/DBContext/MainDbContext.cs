using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using XPBAZAR.Entity;
namespace XPBAZAR.DBContext
{
    public partial class MainDbContext : DbContext
    {
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.CategoryId).IsRequired();
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Quantity).IsRequired();
                entity.Property(e => e.Amount).IsRequired();
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).IsRequired();
                entity.Property(e => e.Name).IsRequired();
            });
        }
    }
}
