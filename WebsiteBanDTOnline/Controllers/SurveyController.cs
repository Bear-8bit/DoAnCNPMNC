using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanDTOnline.Models.EF;
using WebsiteBanDTOnline.Models;

namespace WebsiteBanDTOnline.Controllers
{
    public class SurveyController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Survey
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Partial_Survey()
        {
            return PartialView();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitSurvey(SurveyViewModel req)
        {
            var code = new { Success = false, Code = -1 };
            if (ModelState.IsValid)
            {
                    Survey survey = new Survey();
                    survey.CustomerName = req.CustomerName;
                    survey.Age = req.Age;
                    survey.Email = req.Email;
                    survey.CreatedDate = DateTime.Now;
                    survey.IsRecommended = req.IsRecommended;
                    survey.IsNotRecommended = req.IsNotRecommended;
                    survey.Is1Star = req.Is1Star;
                    survey.Is2Star = req.Is2Star;
                    survey.Is3Star = req.Is3Star;
                    survey.Is4Star = req.Is4Star; 
                    survey.Is5Star = req.Is5Star;
                    survey.Comment = req.Comment;
                    Random rd = new Random();
                    survey.Code = "KS" + rd.Next(0,9) + rd.Next(0,9) + rd.Next(0, 9) + rd.Next(0, 9);
                    db.Surveys.Add(survey);
                    db.SaveChanges();
                    return RedirectToAction("SurveySuccess");
            }
            return Json(code);
        }
        public ActionResult SurveySuccess()
        {
            return View();
        }
    }
}