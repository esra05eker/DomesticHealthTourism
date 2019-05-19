using DHT.BLL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DHT.App.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // bütün iller
            var cities = CityRepository.GetCities();

            return View(cities); // view içerisine il listesini model olarak gönder
        }

        public ActionResult HowItWorks()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

    }
}