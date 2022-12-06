using Microsoft.AspNetCore.Mvc;
using PetsOn.Services.Interfaces;
using PetsOn.Models;
using PetsOn.Helpers;
using PetsOn.Domain.Entities;

namespace PetsOn.Controllers
{
    public class AnimalController : Controller
    {
        readonly IServiceAplicationAnimal ServiceAplicationAnimal;
        protected IHttpContextAccessor HttpContextAcessor;
        public AnimalController(
            IServiceAplicationAnimal serviceAplicationAnimal,
            IHttpContextAccessor httpContextAcessor)
        {
            ServiceAplicationAnimal = serviceAplicationAnimal;
            HttpContextAcessor = httpContextAcessor;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(ServiceAplicationAnimal.Listagem((int)HttpContextAcessor.HttpContext.Session.GetInt32(Sessao.CODIGO_PETSHOP)));
        }

        [HttpGet]
        [HttpGet]
        public IActionResult PetsCliente(int? id)
        {
            return View(ServiceAplicationAnimal.ListagemPetsCliente((int)id));
        }

        [HttpGet]
        public IActionResult AnimalCadastro(int? id)
        {
            AnimalViewModel viewModel = new AnimalViewModel();
            viewModel.Codigo_Cliente = (int)HttpContextAcessor.HttpContext.Session.GetInt32(Sessao.CODIGO_CLIENTE);

            if (id != null)
            {
                viewModel = ServiceAplicationAnimal.CarregarRegistro((int)id);
            }
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AnimalCadastro(AnimalViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                ServiceAplicationAnimal.Cadastrar(entidade);
            }
            else
            {
                return View(entidade);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Validation()
        {
            var model = new AnimalViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Validation(AnimalViewModel input)
        {
            if (this.ModelState.IsValid)
            {
                return this.RedirectToAction("Validation");
            }

            return View(input);
        }
    }
}