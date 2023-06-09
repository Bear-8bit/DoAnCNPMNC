﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanDTOnline.Models;
using PagedList;

namespace WebsiteBanDTOnline.Areas.Admin.Controllers
{
    public class SurveyController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Survey
        public ActionResult Index(int? page)
        {
            var items = db.Surveys.OrderByDescending(x => x.CreatedDate).ToList();
            if (page == null)
            {
                page = 1;
            }
            var pageNumber = page ?? 1;
            var pageSize = 10;
            ViewBag.PageSize = pageSize;
            ViewBag.Page = pageNumber;
            return View(items.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult ViewSurvey(int id)
        {
            var item = db.Surveys.Find(id);
            return View(item);
        }
    }
}