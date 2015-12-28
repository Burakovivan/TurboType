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
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase upload)
        {
            if (upload != null)
            {
                using (TTContext db = new TTContext())
                {
                    lock (db)
                    {
                        // получаем имя файла
                        string fileName = System.IO.Path.GetFileName(upload.FileName);
                        // сохраняем файл в папку Files в проекте
                        upload.SaveAs(Server.MapPath("~/Photos/" + fileName));
                        db.Users.Where(x => x.Email == User.Identity.Name).First().Photo = fileName;
                        db.SaveChanges();
                    }
                }
            }
            return RedirectToAction("Index", "Manage");
        }
    }
}