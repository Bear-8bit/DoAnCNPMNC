using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanDTOnline.Models;
using WebsiteBanDTOnline.Models.EF;

namespace WebsiteBanDTOnline.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Category
        public ActionResult Index()
        {
            var items = db.Categories;
            return View(items);
        }
        public ActionResult Add() 
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Categories model)
        {
            if(ModelState.IsValid) 
            {
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now.ToString();
                model.Alias = WebsiteBanDTOnline.Models.Common.Filter.FilterChar(model.Name);
                db.Categories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Edit(int id) 
        {
            var item = db.Categories.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categories model)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Attach(model); 
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now.ToString();
                model.Alias = WebsiteBanDTOnline.Models.Common.Filter.FilterChar(model.Name);
                db.Entry(model).Property(x => x.Name).IsModified = true;
                db.Entry(model).Property(x => x.Description).IsModified = true;
                db.Entry(model).Property(x => x.Alias).IsModified = true;
                db.Entry(model).Property(x => x.SeoTitle).IsModified = true;
                db.Entry(model).Property(x => x.SeoDescription).IsModified = true;
                db.Entry(model).Property(x => x.Seokeywords).IsModified = true;
                db.Entry(model).Property(x => x.ModifiedDate).IsModified = true;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.News.Find(id);
            if(item != null)
            {
                db.News.Remove(item); 
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}