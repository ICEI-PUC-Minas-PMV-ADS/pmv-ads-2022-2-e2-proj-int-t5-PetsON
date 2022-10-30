using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetsOn.DAL;
using PetsOn.Domain.Entities;
using PetsOn.Models.Usuario;

namespace PetsOn.Controllers
{
    public class UsuarioController : Controller
    {
        ApplicationDbContext _mContext;

        public UsuarioController(ApplicationDbContext mContext) => _mContext = mContext;

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(RegistroPetshopViewModel input)
        {
            var petshop = new Petshop()
            {
                Nome_Empresa = input.NomeEmpresa,
                Cnpj = input.Cnpj,
                Web_Site = input.WebSite,
                Descricao = input.Descricao
            };

            _mContext.Petshop.Add(petshop);
            var idPetshop = _mContext.SaveChanges();

            var usuario = new Usuario()
            {
                Nome_Usuario = input.Nome + input.Sobrenome,
                Email = input.Email,
                Senha = input.Senha,
                Id_Petshop = idPetshop
            };

            _mContext.Usuario.Add(usuario);
            _mContext.SaveChanges();

            Thread.Sleep(2000);
            return View();
        }

    }
}