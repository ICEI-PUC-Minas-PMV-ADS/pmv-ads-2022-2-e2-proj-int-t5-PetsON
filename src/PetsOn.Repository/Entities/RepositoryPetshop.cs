using PetsOn.Domain.Entities;
using PetsOn.Domain.Repository;
using PetsOn.Repository.DAL;

namespace PetsOn.Repository.Entities
{ 
    public class RepositoryPetshop : Repository<Petshop>, IRepositoryPetshop
    {
       public RepositoryPetshop(ApplicationDbContext dbContext) : base(dbContext) {
       }
    }
}
