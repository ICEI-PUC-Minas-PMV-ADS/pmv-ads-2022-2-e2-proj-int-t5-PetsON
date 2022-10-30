using Microsoft.AspNetCore.Mvc;
using PetsOn.Models;
using System.Diagnostics;

namespace PetsOn.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            Thread.Sleep(2500);

            return View();
        }

    }
}