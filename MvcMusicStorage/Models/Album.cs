using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStorage.Models
{
    /// <summary>
    /// Artist's album
    /// </summary>
    public class Album
    {
        /// <summary>
        /// Primary key for Album entity
        /// </summary>
        [Key]
        public int AlbumID { get; set; }

        /// <summary>
        /// Artist ID in corresponding table
        /// </summary>
        public int ArtistID { get; set; }

        /// <summary>
        /// Performer
        /// </summary>
        public Artist Artist { get; set; }

        /// <summary>
        /// Album's name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Year of production
        /// </summary>
        public int? Year { get; set; }

        /// <summary>
        /// URL to album image
        /// </summary>
        public string ImgUrl { get; set; }
    }
}