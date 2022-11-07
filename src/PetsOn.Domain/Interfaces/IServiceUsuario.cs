using PetsOn.Domain.Entities;

namespace Domain.Interfaces
{
    public interface IServiceUsuario : IServiceCRUD<Usuario>
    {
        bool ValidarLogin(string email, string senha);
    }
}
