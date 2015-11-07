using MvcMusicStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStorage.BLL.Interfaces
{
    /// <summary>
    /// Provides albums data manipulation capability
    /// </summary>
    public interface IAlbumRepository
    {
        /// <summary>
        /// Get all albums of specified artist
        /// </summary>
        /// <param name="artistId"></param>
        /// <returns></returns>
        IEnumerable<Album> GetArtistAlbums(int artistId);
    }
}
