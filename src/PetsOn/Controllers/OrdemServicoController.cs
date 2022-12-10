using Microsoft.AspNetCore.Mvc;
using PetsOn.Repository.DAL;
using PetsOn.Services.Interfaces;
using PetsOn.Models;
using PetsOn.Helpers;

namespace PetsOn.Controllers
{
    public class OrdemServicoController : Controller
    {
        protected IHttpContextAccessor HttpContextAcessor;
        public OrdemServicoController(
            IHttpContextAccessor httpContextAcessor)
        {
            HttpContextAcessor = httpContextAcessor;
        }

        [HttpGet]
        public IActionResult OrdemServicoCadastro()
        {
            return View();
        }

    }
}