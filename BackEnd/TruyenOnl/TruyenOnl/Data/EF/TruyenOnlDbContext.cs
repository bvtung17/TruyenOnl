using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TruyenOnl.Data.Configurations;
using TruyenOnl.Data.Entities;
using TruyenOnl.Models;

namespace TruyenOnl.Data
{
    public class TruyenOnlDbContext : DbContext
    {
        public TruyenOnlDbContext(DbContextOptions<TruyenOnlDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<IFormFile>();

            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new BookInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ChapterConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<BookInCategory> BookInCategories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
    }
}
