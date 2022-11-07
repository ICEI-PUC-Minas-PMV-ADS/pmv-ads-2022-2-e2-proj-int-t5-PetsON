using PetsOn.Domain.Entities;
using PetsOn.Repository.DAL;
using PetsOn.Domain.Repository;

namespace PetsOn.Repository.Entities
{ 
    public class RepositoryCliente : Repository<Cliente>, IRepositoryCliente
    {
       public RepositoryCliente(ApplicationDbContext dbContext) : base(dbContext) {
       }
    }
}
