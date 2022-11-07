using PetsOn.Domain.Entities;

namespace PetsOn.Services.Interfaces
{
    public interface IServiceAplicationUsuario
    {
        bool ValidarLogin(string email, string senha);

        Usuario RetornarDadosUsuario(string email, string senha);
    }
}
