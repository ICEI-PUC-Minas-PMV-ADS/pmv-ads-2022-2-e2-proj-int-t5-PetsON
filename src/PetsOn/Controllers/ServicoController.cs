using Microsoft.AspNetCore.Mvc;
using PetsOn.Repository.DAL;
using PetsOn.Services.Interfaces;
using PetsOn.Models;
using PetsOn.Helpers;

namespace PetsOn.Controllers
{
    public class ServicoController : Controller
    {
        readonly IServiceAplicationServico ServiceAplicationServico;
        protected IHttpContextAccessor HttpContextAcessor;
        public ServicoController(
            IServiceAplicationServico serviceAplicationServico,
            IHttpContextAccessor httpContextAcessor)
        {
            ServiceAplicationServico = serviceAplicationServico;
            HttpContextAcessor = httpContextAcessor;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(ServiceAplicationServico.Listagem());
        }

        [HttpGet]
        public IActionResult IndexEd(int? id)
        {
            return View(ServiceAplicationServico.ListagemEdicao((int)id));
        }

        [HttpGet]
        public IActionResult ServicoCadastro(int? id)
        {
            ServicoViewModel viewModel = new ServicoViewModel();

            if (id != null)
            {
                viewModel = ServiceAplicationServico.CarregarRegistro((int)id);
            }
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult ServicoCadastro(ServicoViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                ServiceAplicationServico.Cadastrar(entidade);
            }
            else
            {
                return View(entidade);
            }

            return RedirectToAction("Index");
        }
    }
}