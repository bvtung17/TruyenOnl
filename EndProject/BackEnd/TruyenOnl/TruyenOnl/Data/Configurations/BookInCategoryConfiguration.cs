using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruyenOnl.Models;

namespace TruyenOnl.Data.Configurations
{
    public class BookInCategoryConfiguration : IEntityTypeConfiguration<BookInCategory>
    {
        public void Configure(EntityTypeBuilder<BookInCategory> builder)
        {
            builder.ToTable("BookInCategories");

            builder.HasKey(t => new { t.CategoryId, t.BookId });

            builder.HasOne(t => t.Book).WithMany(bc => bc.BookInCategories).HasForeignKey(bc => bc.BookId);

            builder.HasOne(t => t.Category).WithMany(bc => bc.BookInCategories).HasForeignKey(bc => bc.CategoryId);
        }
    }
}
