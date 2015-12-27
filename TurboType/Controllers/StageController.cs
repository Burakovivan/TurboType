using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurboType.Models;

namespace TurboType.Controllers
{
    public class StageController : Controller
    {
        // GET: Stage
        [HttpGet]
        public ActionResult Index(int id)
        {
            if (id > -1)
            {

                using (TTContext db = new TTContext())
                {
                    if (db.Stages.Select(s => s.StageId).Contains(id))
                        ViewBag.Current = db.Stages.FirstOrDefault(st => st.StageId == id);
                    else  return RedirectToAction("../Home/Index");
                }
            }


            return View();


        }


    }
}