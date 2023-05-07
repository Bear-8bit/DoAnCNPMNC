using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanDTOnline.Models.EF;
using WebsiteBanDTOnline.Models;

namespace WebsiteBanDTOnline.Controllers
{
    public class WishListController : Controller
    {
        // GET: WishList
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Partical_Item_WishList()
        {
            Wishlist wishlist = (Wishlist)Session["WishList"];
            if (wishlist != null && wishlist.Items.Any())
            {
                return PartialView(wishlist.Items);
            }
            return PartialView();
        }
        [HttpPost]
        public ActionResult AddToWishList(int id)
        {
            var code = new { Success = false, msg = "", code = -1, Count = 1 };
            var db = new ApplicationDbContext();
            var checkProduct = db.Products.FirstOrDefault(x => x.Id == id);
            if (checkProduct != null)
            {
                Wishlist list = (Wishlist)Session["WishList"];
                if (list == null)
                {
                    list = new Wishlist();
                }
                WishlistItem item = new WishlistItem
                {
                    ProductId = checkProduct.Id,
                    ProductName = checkProduct.ProductName,
                    CategoryName = checkProduct.ProductCate_ID,
                    Alias = checkProduct.Alias,
                };
                if (checkProduct.ProductImages.FirstOrDefault(x => x.IsDefault) != null)
                {
                    item.ProductImg = checkProduct.ProductImages.FirstOrDefault(x => x.IsDefault).Image;
                }
                item.Price = checkProduct.Price;
                if (checkProduct.PriceSale > 0)
                {
                    item.Price = (decimal)checkProduct.PriceSale;
                }
                list.AddToWishList(item);
                Session["WishList"] = list;
                code = new { Success = true, msg = "Thêm sản phẩm thành công", code = 1, Count = list.Items.Count };
            }
            return Json(code);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var code = new { Success = false, msg = "", code = -1, Count = 0 };
            Wishlist list = (Wishlist)Session["WishList"];
            if (list != null)
            {
                list.Remove(id);
                code = new { Success = true, msg = "", code = 1, Count = list.Items.Count };
            }
            return Json(code);
        }

        [HttpPost]
        public ActionResult DeleteAll()
        {
            Wishlist list = (Wishlist)Session["WishList"];
            if (list != null)
            {
                list.ClearWishList();
                return Json(new { Success = true });
            }
            return Json(new { Success = false });
        }
    }
}