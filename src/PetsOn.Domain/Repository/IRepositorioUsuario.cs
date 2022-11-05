using PetsOn.Domain.Entities;

namespace PetsOn.Domain.Repository
{
    internal interface IRepositorioUsuario : IRepositorio<Usuario>
    {
            bool ValidarLogin(string email, string senha);
    }
}
