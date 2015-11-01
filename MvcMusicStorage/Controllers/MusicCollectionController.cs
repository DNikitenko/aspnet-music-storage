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
        // GET: MusicCollection
        public ActionResult Index()
        {
            var artistsList = new List<Artist>
            {
                new Artist { Name = "Metallica" },
                new Artist { Name = "Amorphis" },
                new Artist { Name = "Gogol Bordello" }
            };

            return View(artistsList.OrderBy(x => x.Name));
        }
    }
}