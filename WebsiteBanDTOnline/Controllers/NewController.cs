using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanDTOnline.Models;

namespace WebsiteBanDTOnline.Controllers
{
    public class NewController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: News
        public ActionResult Index()
        {
            var items = db.News.ToList();
            return View(items);
        }
        public ActionResult Details(int id) 
        {
            var item = db.News.Find(id);    
            return View(item);
        }
        public ActionResult Partial_New_Home()
        {
            var items = db.News.Take(3).ToList();
            return PartialView(items);
        }
    }
}