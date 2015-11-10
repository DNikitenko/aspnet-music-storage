using MvcMusicStorage.BLL.Interfaces;
using MvcMusicStorage.BLL.Repositories;
using MvcMusicStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStorage.Controllers
{
    public class MusicCollectionController : Controller
    {
        IArtistRepository artistRepository = new ArtistRepository();

        // GET: MusicCollection
        [Authorize]
        public ActionResult Index()
        {
            var artists = artistRepository.GetAll().OrderBy(x => x.Name).ToList();
            return View(artists);
        }
    }
}