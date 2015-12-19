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

                Stage s1 = new Stage() { StageName = "name1", Complexity = 3 };
                Stage s2 = new Stage() { StageName = "name2", Complexity = 4 };
                Stage s3 = new Stage() { StageName = "name3", Complexity = 5 };
                Stage s4 = new Stage() { StageName = "name4", Complexity = 3 };
                Stage s5 = new Stage() { StageName = "name5", Complexity = 2 };
                Stage s6 = new Stage() { StageName = "name6", Complexity = 1 };
                ViewBag.Learning = new List<Stage>() { s1,s2,s4 };
                ViewBag.Competiton = new List<Stage>() { s6,s3,s4 };
                ViewBag.SingleType = new List<Stage>() { s3,s5 };
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