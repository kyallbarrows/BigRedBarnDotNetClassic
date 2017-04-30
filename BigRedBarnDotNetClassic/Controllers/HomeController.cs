using Databasery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigRedBarnDotNetClassic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new FeedPostContext("DefaultConnectionString");
            var allUsers = from p in db.Posts select p.UserId;
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
    }
}