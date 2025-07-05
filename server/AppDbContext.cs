using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 👇 Map C# class to lowercase table names in PostgreSQL
            modelBuilder.Entity<Product>().ToTable("products");
            modelBuilder.Entity<Category>().ToTable("categories");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");

                entity.HasKey(p => p.Id); // Map primary key
                entity.Property(p => p.Id).HasColumnName("id");
                entity.Property(p => p.Name).HasColumnName("name");
                entity.Property(p => p.Sku).HasColumnName("sku");
                entity.Property(p => p.Price).HasColumnName("price");
                entity.Property(p => p.Quantity).HasColumnName("quantity");
                entity.Property(p => p.CategoryId).HasColumnName("category_id");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("categories");

                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).HasColumnName("id");
                entity.Property(c => c.Name).HasColumnName("name");
            });
        }
    }
}
