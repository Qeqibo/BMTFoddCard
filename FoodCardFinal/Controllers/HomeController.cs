
using FoodCard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FoodCard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult List()
        {
            var users = new List<UserModel>
            {
                new UserModel{Name="Tarhan"}
            };
            return View(users);
        }
        public IActionResult Index()
        {
            //viewe taşıma yöntemleri 
            //viewbag
            //model
            //viewdata
            int saat = DateTime.Now.Hour;
            ViewBag.Welcome = saat > 12 ? "İyi Günler" : "Günaydın";
            UserModel usr = new UserModel();
            usr.Name = "Serhat";
            usr.Surname = "Tarhan";
            ViewData["User"] = usr;
            return View(usr);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
