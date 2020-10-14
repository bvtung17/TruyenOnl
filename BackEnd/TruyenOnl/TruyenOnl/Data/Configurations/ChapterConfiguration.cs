using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruyenOnl.Models;

namespace TruyenOnl.Data.Configurations
{
    public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            builder.ToTable("Chapters");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();

            builder.HasOne(x => x.Book).WithMany(x => x.Chapters).HasForeignKey(x => x.BookId);
        }
    }
}
