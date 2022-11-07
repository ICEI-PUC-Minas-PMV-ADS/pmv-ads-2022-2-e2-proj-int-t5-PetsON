using PetsOn.Domain.Entities;
using PetsOn.Domain.Repository;
using PetsOn.Repository.DAL;

namespace PetsOn.Repository.Entities
{
    public class RepositoryOrdemServico : Repository<OrdemServico>, IRepositoryOrdemServico
    {
        public RepositoryOrdemServico(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

    }
}
