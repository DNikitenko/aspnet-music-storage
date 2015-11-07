using MvcMusicStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStorage.BLL.Interfaces
{
    /// <summary>
    /// Provides functionality for artists retrieving
    /// </summary>
    public interface IArtistRepository
    {
        /// <summary>
        /// Get non-filtered artists list
        /// </summary>
        /// <returns></returns>
        IEnumerable<Artist> GetAll();
    }
}