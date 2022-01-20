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
            return View();
        }

        [HttpPost]
        public ActionResult Save(BlogItem item)
        {
            return View();
        }
    }
}