using Microsoft.AspNetCore.Mvc;
using PetsOn.Repository.DAL;
using PetsOn.Services.Interfaces;
using PetsOn.Services;
using Domain.Interfaces;
using PetsOn.Models;

namespace PetsOn.Controllers
{
    public class PetshopController : Controller
    {
        readonly IServiceAplicationPetshop ServiceAplicationPetshop;
        public PetshopController(IServiceAplicationPetshop serviceAplicationPetshop)
        {
            ServiceAplicationPetshop = serviceAplicationPetshop;
        }

        [HttpGet]

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(UsuarioPetshopViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                ServiceAplicationPetshop.Cadastrar(entidade);
            }
            else
            {
                return View();
            }

            return RedirectToAction("SucessoCadastro", "Login");
        }
    }
}