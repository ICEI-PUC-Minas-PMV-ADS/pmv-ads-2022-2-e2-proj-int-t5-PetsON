using Microsoft.AspNetCore.Mvc;
using PetsOn.Repository.DAL;
using PetsOn.Services.Interfaces;
using PetsOn.Models;
using PetsOn.Helpers;

namespace PetsOn.Controllers
{
    public class AgendaController : Controller
    {
        protected IHttpContextAccessor HttpContextAcessor;
        public AgendaController(
            IHttpContextAccessor httpContextAcessor)
        {
            HttpContextAcessor = httpContextAcessor;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

    }
}