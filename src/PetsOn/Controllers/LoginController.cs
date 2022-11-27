using Microsoft.AspNetCore.Mvc;
using PetsOn.Helpers;
using PetsOn.Models;
using PetsOn.Services.Interfaces;

namespace PetsOn.Controllers
{
    public class LoginController : Controller
    {
        protected IHttpContextAccessor HttpContextAcessor;
        readonly IServiceAplicationUsuario ServiceAplicationUsuario;
        public LoginController(
            IServiceAplicationUsuario serviceAplicationUsuario,
            IHttpContextAccessor httpContext)
        {
            ServiceAplicationUsuario = serviceAplicationUsuario;
            HttpContextAcessor = httpContext;
        }

        public IActionResult Login(int? Id)
        {
            //Thread.Sleep(2500);

            if (Id != null)
            {
                if (Id == 0)
                {
                    HttpContextAcessor.HttpContext.Session.Clear();
                }
            }
            return View();
        }

        public IActionResult SucessoCadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            ViewData["ErroLogin"] = string.Empty;

            if (ModelState.IsValid)
            {
                var senha = (model.Senha);

                bool login = ServiceAplicationUsuario.ValidarLogin(model.Email, senha);

                var usuario = ServiceAplicationUsuario.RetornarDadosUsuario(model.Email, senha);

                if (login)
                {
                    // Colocar os dados do usuário na sessão...
                    HttpContextAcessor.HttpContext.Session.SetString(Sessao.NOME_USUARIO, usuario.Nome_Usuario);
                    HttpContextAcessor.HttpContext.Session.SetString(Sessao.EMAIL_USUARIO, usuario.Email);
                    HttpContextAcessor.HttpContext.Session.SetInt32(Sessao.CODIGO_USUARIO, (int)usuario.Id);
                    HttpContextAcessor.HttpContext.Session.SetInt32(Sessao.CODIGO_PETSHOP, (int)usuario.Id_Petshop);
                    HttpContextAcessor.HttpContext.Session.SetInt32(Sessao.LOGADO, 1);

                    return RedirectToAction("Menu", "Menu");
                }
                else
                {
                    ViewData["ErroLogin"] = "O Login informado não existe no sistema!";
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }

    }
}