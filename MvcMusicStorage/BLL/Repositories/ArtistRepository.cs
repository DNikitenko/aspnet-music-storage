using MvcMusicStorage.BLL.Interfaces;
using MvcMusicStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStorage.BLL.Repositories
{
    /// <summary>
    /// Provides functionality for artists retrieving
    /// </summary>
    public class ArtistRepository : IArtistRepository
    {
        /// <summary>
        /// Get non-filtered artists list
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Models.Artist> GetAll()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Artists.ToList();
            }
        }
    }
}