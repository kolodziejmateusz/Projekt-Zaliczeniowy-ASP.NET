using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<AlbumEntity> Albums { get; set; }
        public DbSet<RecordLabelEntity> RecordLabels { get; set; }
        private string DbPath { get; set; }

        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "albums.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecordLabelEntity>().OwnsOne(e => e.Address);

            modelBuilder.Entity<AlbumEntity>().HasOne(e => e.RecordLabel).WithMany(o => o.Albums).HasForeignKey(e => e.RecordLabelId);

            modelBuilder.Entity<AlbumEntity>().HasData(
                
                new AlbumEntity()
                {
                    Id = 1,
                    Name = "Abbey Road",
                    Band = "The Beatles",
                    TrackList = "Come Together, Something, Maxwell's Silver Hammer, Oh! Darling, Octopus's Garden, I Want You (She's So Heavy), Here Comes The Sun, Because, You Never Give Me Your Money, Sun King, Mean Mr. Mustard, Polythene Pam, She Came In Through The Bathroom Window, Golden Slumbers, Carry That Weight, The End, Her Majesty.",
                    ReleaseDate = new DateTime(1969, 9, 26),
                    Duration = "47:23",
                    Popularity = Popularity.High
                },
                new AlbumEntity()
                {
                    Id = 2,
                    Name = "The Dark Side of the Moon",
                    Band = "Pink Floyd",
                    TrackList = "Speak to Me, Breathe, On the Run, Time, The Great Gig in the Sky, Money, Us and Them, Any Colour You Like, Brain Damage, Eclipse.",
                    ReleaseDate = new DateTime(1973, 3, 1),
                    Duration = "42:49",
                    Popularity = Popularity.TopChart
                },
                new AlbumEntity()
                {
                    Id = 3,
                    Name = "Nasza Ziemia Eden",
                    Band = "Papa Dance",
                    TrackList = "Galaktyczny zwiad, Nasz Disneyland, Temat na clip, It's a simple song, Zły omen, Czas szaleństwa, Nietykalni, Ciało i talent..., Skajlajt, Twój ziemski Eden, The End",
                    ReleaseDate = new DateTime(1989, 3, 1),
                    Duration = "57:03",
                    Popularity = Popularity.Moderate
                },
                new AlbumEntity()
                {
                    Id = 4,
                    Name = "Zawsze Tam, Gdzie Ty",
                    Band = "Lady Pank",
                    TrackList = "Dopóki da czas, Przerwa w trasie, Co mnie to obchodzi, Jak igła, Nie omijaj mnie, Niedokończona ulica, Nie wpychaj mnie w to dno, Zawsze tam gdzie ty, Zapłacę każdą cenę, Wiara we wroga",
                    ReleaseDate = new DateTime(1994, 1, 1),
                    Duration = "41:27",
                    Popularity = Popularity.High
                },
                new AlbumEntity()
                {
                    Id = 5,
                    Name = "Synchronicity",
                    Band = "The Police",
                    TrackList = "Synchronicity I, Walking in Your Footsteps, O My God, Mother, Miss Gradenko, Synchronicity II, Every Breath You Take, King of Pain, Wrapped Around Your Finger, Tea in the Sahara",
                    ReleaseDate = new DateTime(1983, 6, 17),
                    Duration = "44:18",
                    Popularity = Popularity.TopChart
                },
                new AlbumEntity()
                {
                    Id = 6,
                    Name = "Thriller",
                    Band = "Michael Jackson",
                    TrackList = "Wanna Be Startin' Somethin', Baby Be Mine, The Girl Is Mine, Thriller, Beat It, Billie Jean, Human Nature, P.Y.T. (Pretty Young Thing), The Lady in My Life",
                    ReleaseDate = new DateTime(1982, 11, 30),
                    Duration = "42:19",
                    Popularity = Popularity.TopChart
                },
                new AlbumEntity()
                {
                    Id = 7,
                    Name = "Back in Black",
                    Band = "AC/DC",
                    TrackList = "Hells Bells, Shoot to Thrill, What Do You Do for Money Honey, Givin the Dog a Bone, Let Me Put My Love Into You, Back in Black, You Shook Me All Night Long, Have a Drink on Me, Shake a Leg, Rock and Roll Ain't Noise Pollution",
                    ReleaseDate = new DateTime(1980, 7, 25),
                    Duration = "42:11",
                    Popularity = Popularity.TopChart
                });
        }
    }
}
