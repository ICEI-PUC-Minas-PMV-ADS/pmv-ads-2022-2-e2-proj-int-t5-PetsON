using Microsoft.AspNetCore.Mvc;

namespace PetsOn.Controllers
{
    public class MenuController : Controller
    {

        public IActionResult Menu()
        {
            //Thread.Sleep(1000);

            return View();
        }

    }
}