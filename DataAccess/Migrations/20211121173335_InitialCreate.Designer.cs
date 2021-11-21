﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211121173335_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateOfBirth");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("InstagramUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Insta");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Phone");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(2015, 7, 20, 18, 30, 25, 0, DateTimeKind.Unspecified),
                            Email = "mail1@mail.fi",
                            InstagramUrl = "https://metanit.com/sharp/tutorial/19.1.php",
                            Name = "Ed Sheeran",
                            Phone = "+3638778677"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1980, 6, 20, 18, 30, 25, 0, DateTimeKind.Unspecified),
                            Email = "mail1@mail.no",
                            InstagramUrl = "https://insta123",
                            Name = "Doja Cat",
                            Phone = "+3638778655"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1990, 5, 20, 18, 30, 25, 0, DateTimeKind.Unspecified),
                            Email = "mail1@mail.dk",
                            InstagramUrl = "https://insta124",
                            Name = "Ariana Grande",
                            Phone = "12345"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(2000, 4, 20, 18, 30, 25, 0, DateTimeKind.Unspecified),
                            Email = "mail1@mail.de",
                            InstagramUrl = "https://insta125",
                            Name = "Shivers",
                            Phone = "+3638778111"
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(2010, 3, 20, 18, 30, 25, 0, DateTimeKind.Unspecified),
                            Name = "Olivia Rodrigo"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.ArtistSong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ArtistSongId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int")
                        .HasColumnName("ArtistId");

                    b.Property<int>("SongId")
                        .HasColumnType("int")
                        .HasColumnName("SongId");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("SongId");

                    b.ToTable("ArtistSong");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 1,
                            SongId = 1
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 1,
                            SongId = 4
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 3,
                            SongId = 4
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 3,
                            SongId = 2
                        },
                        new
                        {
                            Id = 5,
                            ArtistId = 4,
                            SongId = 3
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Dance-pop"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Pop"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Soul"
                        },
                        new
                        {
                            Id = 4,
                            Title = "R&B"
                        },
                        new
                        {
                            Id = 5,
                            Title = "Pop-punk"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<decimal>("Duration")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Duration");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleasedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ReleaseDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Duration = 2.5m,
                            GenreId = 0,
                            ReleasedDate = new DateTime(2015, 7, 20, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Butter"
                        },
                        new
                        {
                            Id = 2,
                            Duration = 2.3m,
                            GenreId = 0,
                            ReleasedDate = new DateTime(1976, 7, 20, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Leave the door open"
                        },
                        new
                        {
                            Id = 3,
                            Duration = 2.0m,
                            GenreId = 0,
                            ReleasedDate = new DateTime(2001, 7, 20, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Kiss me more"
                        },
                        new
                        {
                            Id = 4,
                            Duration = 1.5m,
                            GenreId = 0,
                            ReleasedDate = new DateTime(2014, 7, 20, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Save your tears"
                        },
                        new
                        {
                            Id = 5,
                            Duration = 1.8m,
                            GenreId = 0,
                            ReleasedDate = new DateTime(2020, 7, 20, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "good 4 u"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.ArtistSong", b =>
                {
                    b.HasOne("DataAccess.Models.Artist", "Artist")
                        .WithMany("ArtistSongs")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.Song", "Song")
                        .WithMany("ArtistSongs")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("DataAccess.Models.Song", b =>
                {
                    b.HasOne("DataAccess.Models.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("DataAccess.Models.Artist", b =>
                {
                    b.Navigation("ArtistSongs");
                });

            modelBuilder.Entity("DataAccess.Models.Genre", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("DataAccess.Models.Song", b =>
                {
                    b.Navigation("ArtistSongs");
                });
#pragma warning restore 612, 618
        }
    }
}
