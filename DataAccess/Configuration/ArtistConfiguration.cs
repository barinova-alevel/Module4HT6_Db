using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Models;
using System;
using System.Collections.Generic;

namespace DataAccess.Configuration
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(p => p.Name).IsRequired().HasColumnName("Name");
            builder.Property(p => p.DateOfBirth).IsRequired().HasColumnName("DateOfBirth");
            builder.Property(p => p.Phone).HasColumnName("Phone");
            builder.Property(p => p.Email).HasColumnName("Email");
            builder.Property(p => p.InstagramUrl).HasColumnName("Insta");

            builder.HasData(new List<Artist>()
            { new Artist() { Id = 1, Name = "Ed Sheeran", DateOfBirth = new DateTime(2015, 7, 20, 18, 30, 25), Phone = "+3638778677", Email = "mail1@mail.fi", InstagramUrl = "https://metanit.com/sharp/tutorial/19.1.php" },
             new Artist() { Id = 2, Name = "Doja Cat", DateOfBirth = new DateTime(1980, 6, 20, 18, 30, 25), Phone = "+3638778655", Email = "mail1@mail.no", InstagramUrl = "https://insta123" },
            new Artist() { Id = 3, Name = "Ariana Grande", DateOfBirth = new DateTime(1990, 5, 20, 18, 30, 25), Phone = "12345", Email = "mail1@mail.dk", InstagramUrl = "https://insta124" },
            new Artist() { Id = 4, Name = "Shivers", DateOfBirth = new DateTime(2000, 4, 20, 18, 30, 25), Phone = "+3638778111", Email = "mail1@mail.de", InstagramUrl = "https://insta125" },
            new Artist() { Id = 5, Name = "Olivia Rodrigo", DateOfBirth = new DateTime(2010, 3, 20, 18, 30, 25)}
            });
        }
    }
}
