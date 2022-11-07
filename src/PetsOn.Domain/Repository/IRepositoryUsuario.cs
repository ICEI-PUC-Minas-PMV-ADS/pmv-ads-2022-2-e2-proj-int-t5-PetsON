using PetsOn.Domain.Entities;

namespace PetsOn.Domain.Repository
{
    public interface IRepositoryUsuario : IRepository<Usuario>
    {
            bool ValidarLogin(string email, string senha);
    }
}
