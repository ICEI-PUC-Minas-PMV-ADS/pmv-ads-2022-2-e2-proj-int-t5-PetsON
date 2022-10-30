using Microsoft.AspNetCore.Mvc;
using PetsOn.Models;
using System.Diagnostics;

namespace PetsOn.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}