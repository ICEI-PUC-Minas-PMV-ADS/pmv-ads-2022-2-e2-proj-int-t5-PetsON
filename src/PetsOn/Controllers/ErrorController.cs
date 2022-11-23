using Microsoft.AspNetCore.Mvc;

namespace PetsOn.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
