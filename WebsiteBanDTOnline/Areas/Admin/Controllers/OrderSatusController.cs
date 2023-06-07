using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanDTOnline.Models;
using WebsiteBanDTOnline.Models.EF;

namespace WebsiteBanDTOnline.Areas.Admin.Controllers
{
    public class OrderSatusController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/OrderSatus
        public ActionResult Index(string SearchText, int? page)
        {
            var pageSize = 6;
            if (page == null)
            {
                page = 1;
            }
            IEnumerable<OrderStatus> items = db.OrderStatuses.OrderByDescending(x => x.Id);
            if (!string.IsNullOrEmpty(SearchText))
            {
            }
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items = items.ToPagedList(pageIndex, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
            return View(items);
        }
    }
}