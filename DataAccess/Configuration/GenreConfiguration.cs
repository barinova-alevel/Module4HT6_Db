using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Models;
using System;
using System.Collections.Generic;

namespace DataAccess.Configuration
{
    class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(p => p.Title).IsRequired().HasColumnName("Title");

            builder.HasData(new List<Genre>()
            {
                new Genre() { Id = 1, Title = "Dance-pop"},
                new Genre() { Id = 2, Title = "Pop"},
                new Genre() { Id = 3, Title = "Soul"},
                new Genre() { Id = 4, Title = "R&B"},
                new Genre() { Id = 5, Title = "Pop-punk"}
            });
        }
    }
}
