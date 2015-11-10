using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStorage.Models
{
    /// <summary>
    /// Represents a single performer or a musical band
    /// </summary>
    public class Artist
    {
        /// <summary>
        /// Primary key for Artist entity
        /// </summary>
        [Key]
        public int ArtistID { get; set; }

        /// <summary>
        /// Artist name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Additional performer information
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// List of performer's albums
        /// </summary>
        public ICollection<Album> Albums { get; set; }
    }
}