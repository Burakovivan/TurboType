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
                    {
                        ViewBag.Current = db.Stages.FirstOrDefault(st => st.StageId == id);
                        if (db.PassedStages.Where(p => p.User.Email == User.Identity.Name && p.Stage.StageId == id).Count() > 0)
                        {
                            ViewBag.IsPass = true;
                            ViewBag.Passed = db.PassedStages.Single(p => p.User.Email == User.Identity.Name && p.Stage.StageId == id);
                        }
                        else
                        {
                            ViewBag.IsPass = false;
                        }

                    }
                    else return RedirectToAction("Index", "Home");
                }
            }


            return View();


        }

        public ActionResult SubmitStageResult(int speed, int mistakes, int index, int isNext, int rating)
        {
            if (isNext == 1)
            {
                using (TTContext db = new TTContext())
                {
                    PassedStage cur = new PassedStage();
                    int minSpeed = db.Stages.First(s => s.StageId == index).MinimalSpeed;
                    cur.Rating = rating;
                    cur.StageId = index;
                    cur.TimeOfPassage = DateTime.Now;
                    cur.UserId = db.Users.Single(user => user.Email == User.Identity.Name).Id;

                    if (db.PassedStages.Count(p => p.StageId == cur.StageId && p.UserId == cur.UserId) > 0)
                    {
                        if (db.PassedStages.Where(p => p.StageId == cur.StageId && p.UserId == cur.UserId).First().Rating < cur.Rating)
                        {
                            db.Users.Single(user => user.Email == User.Identity.Name).Rating += cur.Rating - db.PassedStages.Where(p => p.StageId == cur.StageId && p.UserId == cur.UserId).First().Rating;
                            db.PassedStages.Where(p => p.StageId == cur.StageId && p.UserId == cur.UserId).First().Rating = cur.Rating;
                        }
                    }
                    else
                    {
                        db.PassedStages.Add(cur);
                        db.Users.Single(user => user.Email == User.Identity.Name).Rating += cur.Rating;
                    }


                    db.SaveChanges();

                    if (db.Stages.Select(s => s.StageId).Contains(index + 1))
                        return RedirectToAction("Index/" + (index + 1), "Stage");
                    else
                        return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return RedirectToAction("Index/" + index, "Stage");
            }


        }


    }
}