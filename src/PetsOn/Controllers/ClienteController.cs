using Microsoft.AspNetCore.Mvc;
using PetsOn.Repository.DAL;
using PetsOn.Services.Interfaces;
using PetsOn.Models;

namespace PetsOn.Controllers
{
    public class ClienteController : Controller
    {
        readonly IServiceAplicationCliente ServiceAplicationCliente;
        public ClienteController(IServiceAplicationCliente serviceAplicationCliente)
        {
            ServiceAplicationCliente = serviceAplicationCliente;
        }

        [HttpGet]

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ClienteAnimalViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                ServiceAplicationCliente.Cadastrar(entidade);
            }
            else
            {
                return View();
            }

            return RedirectToAction("SucessoCadastro", "Login");
        }
    }
}