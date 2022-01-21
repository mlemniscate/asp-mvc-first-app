using MvcFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFirstApp.Controllers
{
    public class BlogItemController : Controller
    {
        public ActionResult Save()
        {
            return View(new BlogItem());
        }

        [HttpPost]
        public ActionResult Save(BlogItem item)
        {
            using (BlogDbContext blogDbContext = new BlogDbContext())
            {
                using (BlogDbContext db = new BlogDbContext())
                {
                    db.BlogItems.Add(item);
                    db.SaveChanges();
                }
            }
            return View(item);
        }
    }
}