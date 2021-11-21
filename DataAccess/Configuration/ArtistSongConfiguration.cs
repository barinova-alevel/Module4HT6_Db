using Microsoft.EntityFrameworkCore;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DataAccess.Configuration
{
    public class ArtistSongConfiguration : IEntityTypeConfiguration<ArtistSong>
    {
        public void Configure(EntityTypeBuilder<ArtistSong> builder)
        {
            builder.ToTable("ArtistSong").HasKey(a => a.Id);
            builder.Property(p => p.Id).IsRequired().HasColumnName("ArtistSongId");
            builder.Property(p => p.ArtistId).IsRequired().HasColumnName("ArtistId");
            builder.Property(p => p.SongId).IsRequired().HasColumnName("SongId");

            builder.HasOne(a => a.Artist)
                .WithMany(x => x.ArtistSongs)
                .HasForeignKey(a => a.ArtistId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(s => s.Song)
                .WithMany(x => x.ArtistSongs)
                .HasForeignKey(s => s.SongId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new List<ArtistSong>()
            {
                new ArtistSong(){ Id = 1, ArtistId = 1, SongId = 1},
                new ArtistSong(){ Id = 2, ArtistId = 1, SongId = 4},
                new ArtistSong(){ Id = 3, ArtistId = 3, SongId = 4},
                new ArtistSong(){ Id = 4, ArtistId = 3, SongId = 2},
                new ArtistSong(){ Id = 5, ArtistId = 4, SongId = 3}
            });
        }

    }
}
