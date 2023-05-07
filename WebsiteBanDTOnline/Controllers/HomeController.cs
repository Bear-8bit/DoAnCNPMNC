using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanDTOnline.Models;
using WebsiteBanDTOnline.Models.EF;

namespace WebsiteBanDTOnline.Controllers
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
        public ActionResult Partial_Subcribe()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Subscribe(Subcribe req)
        {
            if(ModelState.IsValid)
            {
                db.Subcribes.Add(new Subcribe { Email = req.Email, CreatedDate = DateTime.Now });
                db.SaveChanges();
            }
            return View("Index", req);
        }
        public ActionResult Refresh() 
        {
            var item = new ThongKeModel();
            ViewBag.visitor_online = HttpContext.Application["visitor_online"];
            item.HomNay = HttpContext.Application["HomNay"] as string;
            item.HomQua = HttpContext.Application["HomQua"] as string;
            item.TuanNay = HttpContext.Application["TuanNay"] as string;
            item.TuanTruoc = HttpContext.Application["TuanTruoc"] as string;
            item.ThangNay = HttpContext.Application["ThangNay"] as string;
            item.ThangTruoc = HttpContext.Application["ThangTruoc"] as string;
            item.TatCa = HttpContext.Application["TatCa"] as string;
            return PartialView(item);
        }
    }
}