using Microsoft.AspNetCore.Mvc;

namespace PetsOn.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            Thread.Sleep(2500);

            return View();
        }

        public IActionResult SucessoCadastro()
        {
            return View();
        }
    }
}