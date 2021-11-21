using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using DataAccess.Configuration;

namespace DataAccess
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Artist>  Artists {get; set;}

        public DbSet<ArtistSong>  ArtistSongs {get; set;}

        public DbSet<Genre>  Genres {get; set;}

        public DbSet<Song>  Songs {get; set;}

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistSongConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new SongConfiguration());
        }
    }
}
