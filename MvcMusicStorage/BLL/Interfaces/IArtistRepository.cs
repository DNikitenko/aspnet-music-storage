using MvcMusicStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStorage.BLL.Interfaces
{
    public interface IArtistRepository
    {
        IEnumerable<Artist> GetAll();
    }
}