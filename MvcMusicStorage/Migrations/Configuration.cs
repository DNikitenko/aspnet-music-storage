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

            var metallicaObject = context.Artists.First(x => x.Name == "Metallica");
            context.Albums.AddOrUpdate(
                x => x.Name,
                new Album { ArtistID = metallicaObject.ArtistID, Name = "Ride the lightning", Year = 1984, ImgUrl = "http://www.metal-archives.com/images/5/4/4/544.jpg?4439" },
                new Album { ArtistID = metallicaObject.ArtistID, Name = "Master of puppets", Year = 1986, ImgUrl = "https://upload.wikimedia.org/wikipedia/ru/a/a4/%D0%9E%D0%B1%D0%BB%D0%BE%D0%B6%D0%BA%D0%B0_%D1%82%D1%80%D0%B5%D1%82%D1%8C%D0%B5%D0%B3%D0%BE_%D1%81%D1%82%D1%83%D0%B4%D0%B8%D0%B9%D0%BD%D0%BE%D0%B3%D0%BE_%D0%B0%D0%BB%D1%8C%D0%B1%D0%BE%D0%BC%D0%B0_Metallica.jpg" }
            );
        }
    }
}
