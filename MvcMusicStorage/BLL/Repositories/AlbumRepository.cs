using MvcMusicStorage.BLL.Interfaces;
using MvcMusicStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStorage.BLL.Repositories
{
    /// <summary>
    /// Default implementation of IAlbumRepository
    /// </summary>
    public class AlbumRepository : IAlbumRepository
    {
        /// <summary>
        /// Get all albums of specified artist
        /// </summary>
        /// <param name="artistId"></param>
        /// <returns></returns>
        public IEnumerable<Models.Album> GetArtistAlbums(int artistId)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Albums.Where(album => album.ArtistID == artistId).ToList();
            }
        }

        /// <summary>
        /// Get all stored albums
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Models.Album> GetAll()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Albums.ToList();
            }
        }
    }
}