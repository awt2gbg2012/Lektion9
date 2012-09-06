using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lektion9.Models.Entities;

namespace Lektion9.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            Product prod = new Product();
            prod.Name = "Dummy Product - No Repository Interaction";

            return View(prod);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
