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
        public IActionResult Index()
        {
            return View(ServiceAplicationCliente.Listagem());
        }

        [HttpGet]
        public IActionResult ClienteCadastro(int? id)
        {
            ClienteViewModel viewModel = new ClienteViewModel();

            if (id != null)
            {
                viewModel = ServiceAplicationCliente.CarregarRegistro((int)id);
            }
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult ClienteCadastro(ClienteViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                ServiceAplicationCliente.Cadastrar(entidade);
            }
            else
            {
                return View();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Validation()
        {
            var model = new ClienteViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Validation(ClienteViewModel input)
        {
            if (this.ModelState.IsValid)
            {
                return this.RedirectToAction("Validation");
            }

            return View(input);
        }
    }
}