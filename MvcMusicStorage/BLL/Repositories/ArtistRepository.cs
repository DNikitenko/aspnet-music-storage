using MvcMusicStorage.BLL.Interfaces;
using MvcMusicStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStorage.BLL.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        public IEnumerable<Models.Artist> GetAll()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Artists.ToList();
            }
        }
    }
}