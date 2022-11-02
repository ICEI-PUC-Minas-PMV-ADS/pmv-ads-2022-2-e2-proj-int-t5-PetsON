using Microsoft.AspNetCore.Mvc;

namespace PetsOn.Controllers
{
    public class MenuController : Controller
    {

        public IActionResult Menu()
        {
            Thread.Sleep(2000);

            return View();
        }

    }
}