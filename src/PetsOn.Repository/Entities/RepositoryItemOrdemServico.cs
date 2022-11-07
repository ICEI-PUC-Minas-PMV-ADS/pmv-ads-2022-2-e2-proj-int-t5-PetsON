using PetsOn.Domain.Entities;
using PetsOn.Domain.Repository;
using PetsOn.Repository.DAL;

namespace PetsOn.Repository.Entities
{ 
    public class RepositoryItemOrdemServico : IRepositorioItemOrdemServico
    {
        protected ApplicationDbContext DbSetContext;

        public RepositoryItemOrdemServico(ApplicationDbContext mContext)
        {
            DbSetContext = mContext;
        }

    }
}
