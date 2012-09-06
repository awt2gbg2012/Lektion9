using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lektion9.Models.Entities;
using Lektion9.Models.Repositories.Abstract;
using Lektion9.Models.Repositories;

namespace Lektion9.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository Repo;

        public HomeController(IProductRepository repo) {
            Repo = repo;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            Product prod = new Product();
            prod.Id = Guid.NewGuid();
            prod.Name = "Product From DB";
            prod.Price = 35;
            Repo.Add(prod);
            var prod2 = Repo.Products.FirstOrDefault();

            return View(prod2);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
