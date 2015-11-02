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
                new Artist { Name = "Metallica" },
                new Artist { Name = "Amorphis" },
                new Artist { Name = "Gogol Bordello" }
            );
        }
    }
}
