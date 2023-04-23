using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanDTOnline.Models;
using WebsiteBanDTOnline.Models.EF;

namespace WebsiteBanDTOnline.Controllers
{
    public class LoginController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authen(User user)
        {
            var check = db.Userxs.Where(x => x.Email.Equals(user.Email) && x.Password.Equals(user.Password)).FirstOrDefault();
            if (check != null)
            {
                    Session["Id"] = user.Id;
                    Session["Email"] = user.Email;
                    return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Index", user);
            }
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                var check = db.Users.FirstOrDefault(x => x.Email == user.Email);
                if (check == null)
                {
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.Userxs.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Error = "Email đã tồn tại";
                    return View();
                }
            }
            return View();
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index");
        }
    }
}