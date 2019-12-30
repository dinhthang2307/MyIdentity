﻿using identity.Models;
using System.Linq;
using System.Web.Mvc;

namespace identity.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

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

            return View();
        }

        [ChildActionOnly]
        public ActionResult Category()
        {
            var data = db.ProductCategories.ToList();
            return PartialView(data);
        }
    }
}