using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace Asp_Models.Controllers
{
    public class HomeController : Controller
    {
        private MusicStoreDB db = new MusicStoreDB();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            Artist artist = db.Artists.Find(1);
            ViewBag.Message = "About artist :"+artist.Name;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}