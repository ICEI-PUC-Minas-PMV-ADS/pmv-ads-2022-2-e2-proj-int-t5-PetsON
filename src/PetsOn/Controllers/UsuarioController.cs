using Microsoft.AspNetCore.Mvc;
using PetsOn.Services.Interfaces;

namespace PetsOn.Controllers
{
    public class UsuarioController : Controller
    {
        readonly IServiceAplicationUsuario ServiceAplicationUsuario;


        public UsuarioController(IServiceAplicationUsuario serviceAplicationUsuario)
        {
            ServiceAplicationUsuario = serviceAplicationUsuario;
        }
    }
}