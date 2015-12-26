using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurboType.Models;

namespace TurboType.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (TTContext db = new TTContext())
            {

                ViewBag.Learning = db.Stages.ToList();
                ViewBag.Competiton = db.Stages.ToList();
                ViewBag.SingleType = db.Stages.ToList();
            }

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