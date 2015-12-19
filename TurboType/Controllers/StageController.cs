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
            if(id>-1)
            //to do .....
            using (TTContext db = new TTContext())
            {
                ViewBag.Current = db.Stages.FirstOrDefault(st => st.StageId == id);
            }

                return View();
         
                
        }

        
    }
}