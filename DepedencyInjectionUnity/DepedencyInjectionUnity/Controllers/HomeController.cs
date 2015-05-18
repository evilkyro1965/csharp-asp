using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using simpleerp.service;
using simpleerp.model;

namespace DepedencyInjectionUnity.Controllers
{
    public class HomeController : Controller
    {
        private IInventoryCategoryDao inventoryCategoryDao;

        public HomeController(IInventoryCategoryDao inventoryCategoryDao)
        {
            this.inventoryCategoryDao = inventoryCategoryDao;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            InventoryCategory inventoryCategory = new InventoryCategory();
            inventoryCategory.Name = "Create1";
            inventoryCategoryDao.create(inventoryCategory);
            return View();
        }
    }
}