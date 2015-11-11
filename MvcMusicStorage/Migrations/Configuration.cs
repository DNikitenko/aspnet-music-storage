namespace MvcMusicStorage.Migrations
{
    using MvcMusicStorage.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMusicStorage.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MvcMusicStorage.Models.ApplicationDbContext";
        }

        protected override void Seed(MvcMusicStorage.Models.ApplicationDbContext context)
        {
            context.Artists.AddOrUpdate(
                x => x.Name,
                new Artist { Name = "Metallica" },
                new Artist { Name = "Amorphis" },
                new Artist { Name = "Gogol Bordello" }
            );

            context.SaveChanges();

            AddMetallicaAlbums(context);
            AddAmorphisAlbums(context);
            AddGogolBordelloAlbums(context);
        }

        private void AddMetallicaAlbums(MvcMusicStorage.Models.ApplicationDbContext context)
        {
            var metallicaObject = context.Artists.First(x => x.Name == "Metallica");
            context.Albums.AddOrUpdate(
                x => x.Name,
                new Album { ArtistID = metallicaObject.ArtistID, Name = "Ride the lightning", Year = 1984, ImgUrl = "http://www.metal-archives.com/images/5/4/4/544.jpg?4439" },
                new Album { ArtistID = metallicaObject.ArtistID, Name = "Master of puppets", Year = 1986, ImgUrl = "https://upload.wikimedia.org/wikipedia/ru/a/a4/%D0%9E%D0%B1%D0%BB%D0%BE%D0%B6%D0%BA%D0%B0_%D1%82%D1%80%D0%B5%D1%82%D1%8C%D0%B5%D0%B3%D0%BE_%D1%81%D1%82%D1%83%D0%B4%D0%B8%D0%B9%D0%BD%D0%BE%D0%B3%D0%BE_%D0%B0%D0%BB%D1%8C%D0%B1%D0%BE%D0%BC%D0%B0_Metallica.jpg" },
                new Album { ArtistID = metallicaObject.ArtistID, Name = "…And Justice For All", Year = 1988, ImgUrl = "https://upload.wikimedia.org/wikipedia/ru/thumb/d/d7/And_Justice_For_All.jpg/200px-And_Justice_For_All.jpg" },
                new Album { ArtistID = metallicaObject.ArtistID, Name = "Load", Year = 1996, ImgUrl = "https://upload.wikimedia.org/wikipedia/ru/thumb/b/b7/Metallica_Load_Hi-Res.jpg/200px-Metallica_Load_Hi-Res.jpg" }
            );
        }

        private void AddAmorphisAlbums(MvcMusicStorage.Models.ApplicationDbContext context)
        {
            var amorphisObject = context.Artists.First(x => x.Name == "Amorphis");
            context.Albums.AddOrUpdate(
                x => x.Name,
                new Album { ArtistID = amorphisObject.ArtistID, Name = "Skyforger", Year = 2009, ImgUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/6/62/Amorphis_-_Skyforger.JPG/220px-Amorphis_-_Skyforger.JPG" },
                new Album { ArtistID = amorphisObject.ArtistID, Name = "Tuonela", Year = 1999, ImgUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/8/8f/Tuonela.jpg/220px-Tuonela.jpg" },
                new Album { ArtistID = amorphisObject.ArtistID, Name = "Tales from the Thousand Lakes", Year = 1994, ImgUrl = "https://upload.wikimedia.org/wikipedia/ru/thumb/e/ec/Tales_from_the_Thousand_Lakes.jpg/200px-Tales_from_the_Thousand_Lakes.jpg" },
                new Album { ArtistID = amorphisObject.ArtistID, Name = "Circle", Year = 2013, ImgUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a7/AmorphisCircle.jpg.png/220px-AmorphisCircle.jpg.png" },
                new Album { ArtistID = amorphisObject.ArtistID, Name = "The Karelian Isthmus", Year = 1992, ImgUrl = "https://upload.wikimedia.org/wikipedia/ru/thumb/b/b0/Amorphis_-_The_Karelian_Isthmus.jpg/200px-Amorphis_-_The_Karelian_Isthmus.jpg" },
                new Album { ArtistID = amorphisObject.ArtistID, Name = "Under the Red Cloud", Year = 2015, ImgUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a0/Amorphis_Under_The_Red_Cloud.jpg/220px-Amorphis_Under_The_Red_Cloud.jpg" }
            );
        }

        private void AddGogolBordelloAlbums(MvcMusicStorage.Models.ApplicationDbContext context)
        {
            var gogolBordelloObject = context.Artists.First(x => x.Name == "Gogol Bordello");
            context.Albums.AddOrUpdate(
                x => x.Name,
                new Album { ArtistID = gogolBordelloObject.ArtistID, Name = "Pura Vida Conspiracy", Year = 2013, ImgUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d8/Gogol_Bordello_-_Pura_Vida_Conspiracy.jpg/220px-Gogol_Bordello_-_Pura_Vida_Conspiracy.jpg" },
                new Album { ArtistID = gogolBordelloObject.ArtistID, Name = "Trans-Continental Hustle", Year = 2010, ImgUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/c/cc/Trans-ContinentalHustle.jpg/220px-Trans-ContinentalHustle.jpg" },
                new Album { ArtistID = gogolBordelloObject.ArtistID, Name = "Super Taranta!", Year = 2007, ImgUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/6/6f/Super_Taranta%21.jpg/220px-Super_Taranta%21.jpg" },
                new Album { ArtistID = gogolBordelloObject.ArtistID, Name = "Gypsy Punks: Underdog World Strike", Year = 2005, ImgUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/7/78/Gogol_Bordello_Gypsy_Punks_Album_Cover.jpg/220px-Gogol_Bordello_Gypsy_Punks_Album_Cover.jpg" },
                new Album { ArtistID = gogolBordelloObject.ArtistID, Name = "East Infection", Year = 2005, ImgUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9d/Gogol_Bordello_-_East_Infection.jpg/220px-Gogol_Bordello_-_East_Infection.jpg" }
            );
        }
    }
}
