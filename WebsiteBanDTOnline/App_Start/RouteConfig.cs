﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebsiteBanDTOnline
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
              name: "Contact",
              url: "lien-hẹ",
              defaults: new { controller = "Contact", action = "Index", alias = UrlParameter.Optional },
              namespaces: new[] { "WebsiteBanDTOnline.Controllers" }
            );
            routes.MapRoute(
             name: "CheckOut",
             url: "thanh-toan",
             defaults: new { controller = "ShoppingCart", action = "CheckOut", alias = UrlParameter.Optional },
             namespaces: new[] { "WebsiteBanDTOnline.Controllers" }
           );
            routes.MapRoute(
              name: "ShoppingCart",
              url: "gio-hang",
              defaults: new { controller = "ShoppingCart", action = "Index", alias = UrlParameter.Optional },
              namespaces: new[] { "WebsiteBanDTOnline.Controllers" }
            );
            routes.MapRoute(
             name: "WishList",
             url: "danh-sach-uoc",
             defaults: new { controller = "WishList", action = "Index", alias = UrlParameter.Optional },
             namespaces: new[] { "WebsiteBanDTOnline.Controllers" }
           );
            routes.MapRoute(
                name: "CategoryProduct",
                url: "danh-muc-san-pham/{alias}-{id}",
                defaults: new { controller = "Products", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WebsiteBanDTOnline.Controllers" }
            );
            routes.MapRoute(
                name: "DetailProduct",
                url: "chi-tiet/{alias}-{id}",
                defaults: new { controller = "Products", action = "Detail", alias = UrlParameter.Optional },
                namespaces: new[] { "WebsiteBanDTOnline.Controllers" }
            );
            routes.MapRoute(
                name: "Products",
                url: "sản-phảm",
                defaults: new { controller = "Products", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "WebsiteBanDTOnline.Controllers" }
            );
            routes.MapRoute(
                name: "NewList",
                url: "{alias}-n{id}",
                defaults: new { controller = "New", action = "Details", alias = UrlParameter.Optional },
                namespaces: new[] { "WebsiteBanDTOnline.Controllers" }
            );
            routes.MapRoute(
                name: "Promotion",
                url: "tin-túc",
                defaults: new { controller = "New", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "WebsiteBanDTOnline.Controllers" }
            );
            routes.MapRoute(
               name: "DetailNew",
               url: "khuyén-mãi",
               defaults: new { controller = "Promotion", action = "Index", alias = UrlParameter.Optional },
               namespaces: new[] { "WebsiteBanDTOnline.Controllers" }
           );
            routes.MapRoute(
              name: "Survey",
              url: "khảo-sát",
              defaults: new { controller = "Survey", action = "Index", alias = UrlParameter.Optional },
              namespaces: new[] { "WebsiteBanDTOnline.Controllers" }
          );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] {"WebsiteBanDTOnline.Controllers"}
            );
        }
    }
}
