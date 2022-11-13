using PetsOn.Domain.Entities;
using PetsOn.Domain.Repository;
using PetsOn.Repository.DAL;

namespace PetsOn.Repository.Entities
{
    public class RepositoryUsuario : Repository<Usuario>, IRepositoryUsuario
    {
       public RepositoryUsuario(ApplicationDbContext dbContext) : base(dbContext) {
       }

        public bool ValidarLogin(string email, string senha)
        {
            var usuario = DbSetContext.Where(x => x.Email == email && x.Senha.ToUpper() == senha.ToUpper()).FirstOrDefault();
            return (usuario == null) ? false : true;
        }


    }
}
