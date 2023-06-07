using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanDTOnline.Models.EF;
using WebsiteBanDTOnline.Models;

namespace WebsiteBanDTOnline.Controllers
{
    public class UserReviewController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: UserReview
        public ActionResult Partial_UserReview()
        {
            return PartialView();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitUserReview(UserReviewViewModel req)
        {
            var code = new { Success = false, Code = -1 };
            if (ModelState.IsValid)
            {
                UserReviews reviews = new UserReviews();
                reviews.Name = req.Name;
                reviews.Email = req.Email;
                reviews.CreatedDate = DateTime.Now;
                reviews.Is1Star = req.Is1Star;
                reviews.Is2Star = req.Is2Star;
                reviews.Is3Star = req.Is3Star;
                reviews.Is4Star = req.Is4Star;
                reviews.Is5Star = req.Is5Star;
                reviews.Comment = req.Comment;
                Random rd = new Random();
                reviews.Code = "RV" + rd.Next(0, 9) + rd.Next(0, 9) + rd.Next(0, 9) + rd.Next(0, 9);
                db.UserReview.Add(reviews);
                db.SaveChanges();
                return RedirectToAction("Partial_UserReview");
            }
            return Json(code);
        }
        public ActionResult Partial_ReviewList(int id)
        {
                var items = db.UserReview.Where( x=> x.Product.Id == id).Take(12).ToList();
                return PartialView(items);
        }
    }
}