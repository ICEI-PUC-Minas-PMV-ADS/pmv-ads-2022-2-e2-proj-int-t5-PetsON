using Domain.Interfaces;
using PetsOn.Domain.Entities;
using PetsOn.Domain.Repository;

namespace Domain.Service
{
    public class ServicePetshop : IServicePetshop
    {
        IRepositoryPetshop RepositoryPetshop;

        public ServicePetshop(IRepositoryPetshop repositoryPetshop)
        {
            RepositoryPetshop = repositoryPetshop;
        }
        public void Cadastrar(Petshop petshop)
        {
             RepositoryPetshop.Create(petshop);
        }

        public Petshop CarregarRegistro(int id)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Petshop> Listagem(int? IdPetshop)
        {
            return RepositoryPetshop.Read();
        }
    }
}
