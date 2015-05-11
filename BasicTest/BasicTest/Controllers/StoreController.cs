using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasicTest.Models;

namespace BasicTest.Controllers
{
    public class StoreController : Controller
    {
        // GET: Strore
        public string Index()
        {
            return "Hello from Store.Index()";
        }

        public string Browse(String genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }

        public string Details()
        {
            return "Hello from Store.Details()";
        }

        public ActionResult List()
        {
            var albums = new List<Album>();
            for (int i=0; i < 10; i++)
            {
                albums.Add(new Album { Title = "Album" + i });
            }
            return View(albums);
        }

    }
}