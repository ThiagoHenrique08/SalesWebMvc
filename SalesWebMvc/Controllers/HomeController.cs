using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models.ViewModels;


namespace SalesWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "SwIF Technology";
            ViewData["Socios"] = "Socios";
            ViewData["Developer1"] = "Thiago Henrique| CEO at SwiF Technology";
            ViewData["Developer2"] = "Nicolas Jeronimo| CTO at SwiF Technology";
            ViewData["Developer3"] = "Guilherme Franca| CIO at SwiF Technology";
            ViewData["Developer4"] = "Richard Franca| CDO at SwiF Technology";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
