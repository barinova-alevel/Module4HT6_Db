using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace Songs
{
    public class Program
    {
        static void Main(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();
            var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            dbOptionsBuilder.UseSqlServer(connectionString, i => i.CommandTimeout(20));
            dbOptionsBuilder.LogTo(Console.Write);

            var applicationContext = new ApplicationContext(dbOptionsBuilder.Options);
            applicationContext.Database.Migrate();

            //var s = applicationContext.ArtistSongs
            //    .Select(a => new
            //    {
            //        ArtistName = a.Artist.Name,
            //        SongName = a.Song.Title,
            //        Genre = a.Song.Genre.Title
            //    })
            //    .Where(_ => !String.IsNullOrEmpty(_.Genre) 
            //    && !String.IsNullOrEmpty(_.ArtistName)).ToList();

            //var SongCount = applicationContext.Genres
            //    .Select(g => new
            //    {
            //        GenreTitle = g.Title,
            //        CountSongs = g.Songs.Count()
            //    }).ToList();

            //var songs = (from song in applicationContext.Songs
            //            where song.ReleasedDate < applicationContext.Artists.Max(_ => _.DateOfBirth)
            //            select song).ToList();

            var yangerArtist = applicationContext.Artists.Max(_=>_.DateOfBirth);
            var songs = applicationContext.Songs
           .Where(_ => _.ReleasedDate < applicationContext.Artists.Max(_ => _.DateOfBirth)).ToList();

            applicationContext.SaveChanges();
        }
    }
}
