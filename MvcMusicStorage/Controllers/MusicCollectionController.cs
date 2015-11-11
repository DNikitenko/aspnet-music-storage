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
    [Authorize]
    public class MusicCollectionController : Controller
    {
        IArtistRepository artistRepository = new ArtistRepository();
        IAlbumRepository albumRepository = new AlbumRepository();

        // GET: MusicCollection
        public ActionResult Index()
        {
            var artists = artistRepository.GetAll().OrderBy(x => x.Name).ToList();
            return View(artists);
        }

        public ActionResult ArtistAlbums(int id)
        {
            var albums = albumRepository.GetArtistAlbums(id);
            return PartialView("AlbumView", albums);
        }

        public ActionResult Albums()
        {
            var albums = albumRepository.GetAll();
            return PartialView("AlbumView", albums);
        }
    }
}