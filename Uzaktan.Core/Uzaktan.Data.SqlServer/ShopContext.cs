﻿using Microsoft.EntityFrameworkCore;
using Uzaktan.Core.Domain.Entities;

namespace Uzaktan.Data.SqlServer
{
    public class ShopContext:DbContext
    {
        public ShopContext()
        {
            Database.EnsureCreated(); // Veritabanı yoksa oluştur.
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SALIH\\SQLEXPRESS;Database=UzaktanShop;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             
            //Category tablosu Maping ayarları
            modelBuilder.Entity<Category>(builder =>
            {
                builder.HasKey(c => c.Id);
                builder.Property(c => c.Id).HasColumnName("id").UseIdentityColumn(1,1);
                builder.Property(c => c.Name).HasColumnName("category_name").HasColumnType("varchar(50)").IsRequired();
                builder.Property(c => c.IsActive).HasColumnName("is_active").HasDefaultValueSql("1");

                //İlişki kurulumu
               // builder.HasMany(c => c.Products).WithOne(p => p.Category).HasForeignKey(c => c.CatId);

                builder.ToTable("categories");
            });


            //Product tablosu Maping ayarları
            modelBuilder.Entity<Product>(builder =>
            {
                builder.HasKey(p => p.Id);
                builder.Property(p => p.Id).HasColumnName("id").UseIdentityColumn(1, 1);
                builder.Property(p => p.CatId).HasColumnName("category_id");
                builder.Property(p => p.ProductName).HasColumnName("product_name").HasColumnType("varchar(75)").IsRequired();
                builder.Property(p => p.UnitStock).HasColumnName("unit_in_stock").IsRequired();
                builder.Property(p => p.IsActive).HasColumnName("is_active").HasDefaultValueSql("1");
                builder.Property(p => p.CreateDate).HasDefaultValueSql("getdate()").HasColumnName("create_date");
                builder.Property(p => p.LastDate).HasDefaultValueSql("getdate()").HasColumnName("last_update");

                //İlişki kurulumu
                builder.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(c => c.CatId);

                builder.ToTable("products");
            });
        }
    }
}
