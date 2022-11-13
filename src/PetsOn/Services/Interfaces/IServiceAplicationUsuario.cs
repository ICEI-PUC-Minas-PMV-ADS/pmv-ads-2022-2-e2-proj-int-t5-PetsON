using PetsOn.Domain.Entities;
using PetsOn.Models;

namespace PetsOn.Services.Interfaces
{
    public interface IServiceAplicationUsuario
    {
        void Cadastrar(UsuarioPetshopViewModel usuario);
        bool ValidarLogin(string email, string senha);
        Usuario RetornarDadosUsuario(string email, string senha);
    }
}
