using PetsOn.Domain.Entities;
using PetsOn.Domain.Repository;
using PetsOn.Repository.DAL;

namespace PetsOn.Repository.Entities
{ 
    public class RepositoryServico : Repository<Servico>, IRepositoryServico
    {
       public RepositoryServico(ApplicationDbContext dbContext) : base(dbContext) {
       }
    }
}
