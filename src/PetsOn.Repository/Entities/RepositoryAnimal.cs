using PetsOn.Domain.Entities;
using PetsOn.Domain.Repository;
using PetsOn.Repository.DAL;

namespace PetsOn.Repository.Entities
{ 
    public class RepositoryAnimal : Repository<Animal>, IRepositoryAnimal
    {
       public RepositoryAnimal(ApplicationDbContext dbContext) : base(dbContext) {
       }
    }
}
