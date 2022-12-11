using Microsoft.AspNetCore.Mvc;
using PetsOn.Services.Interfaces;
using PetsOn.Models;
using PetsOn.Helpers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PetsOn.Controllers
{
    public class OrdemServicoController : Controller
    {
        protected IHttpContextAccessor HttpContextAcessor;
        readonly IServiceAplicationCliente ServiceAplicationCliente;
        readonly IServiceAplicationAnimal ServiceAplicationAnimal;
        readonly IServiceAplicationOrdemServico ServiceAplicationOrdemServico;
        public OrdemServicoController(
            IHttpContextAccessor httpContextAcessor,
            IServiceAplicationCliente serviceAplicationCliente,
            IServiceAplicationAnimal serviceAplicationAnimal,   
            IServiceAplicationOrdemServico serviceAplicationOrdemServico)
        {
            HttpContextAcessor = httpContextAcessor;
            ServiceAplicationCliente = serviceAplicationCliente;
            ServiceAplicationAnimal = serviceAplicationAnimal;
            ServiceAplicationOrdemServico = serviceAplicationOrdemServico;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(ServiceAplicationOrdemServico.Listagem((int)HttpContextAcessor.HttpContext.Session.GetInt32(Sessao.CODIGO_PETSHOP)));
        }

        [HttpGet]
        public IActionResult IndexEd(int? id)
        {
            return View(ServiceAplicationOrdemServico.ListagemEdicao((int)id));
        }

        [HttpGet]
        public IActionResult OrdemServicoCadastro(int? id)
        {
            OrdemServicoViewModel viewModel = new OrdemServicoViewModel();

            if (id != null)
            {
                viewModel = ServiceAplicationOrdemServico.CarregarRegistro((int)id);
            }

            viewModel.ListaClientes = (IEnumerable<SelectListItem>)ServiceAplicationCliente.ListaClientesDropDownList();
            //viewModel.ListaAnimais = (IEnumerable<SelectListItem>)ServiceAplicationAnimal.ListagemPetsCliente((int)HttpContextAcessor.HttpContext.Session.GetInt32(Sessao.CODIGO_CLIENTE));

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult OrdemServicoCadastro(OrdemServicoViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                ServiceAplicationOrdemServico.Cadastrar(entidade);
            }
            else
            {
                entidade.ListaClientes = (IEnumerable<SelectListItem>)ServiceAplicationCliente.ListaClientesDropDownList();
                //entidade.ListaAnimais = (IEnumerable<SelectListItem>)ServiceAplicationAnimal.ListagemPetsCliente((int)HttpContextAcessor.HttpContext.Session.GetInt32(Sessao.CODIGO_CLIENTE));
                return View(entidade);
            }

            return RedirectToAction("Index");
        }

    }
}