using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanDTOnline.Models;

namespace WebsiteBanDTOnline.Controllers
{
    public class PromotionController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Promotion
        public ActionResult Index()
        {
            var items = db.Promotions.ToList();
            return View(items);
        }
    }
}