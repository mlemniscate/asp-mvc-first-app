using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFirstApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using(BlogDbContext blogDbContext = new BlogDbContext())
            {
                blogDbContext.BlogItems.Add(new Models.BlogItem
                {
                    Description = "my description",
                    Link = "my link",
                    Titr = "my titr"
                });
                blogDbContext.SaveChanges();
            }
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
    }
}