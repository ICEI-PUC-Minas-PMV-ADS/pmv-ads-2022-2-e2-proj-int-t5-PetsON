using Domain.Interfaces;
using PetsOn.Domain.Entities;
using PetsOn.Domain.Repository;

namespace Domain.Service
{
    public class ServiceServico : IServiceServico
    {
        IRepositoryServico RepositoryServico;

        public ServiceServico(IRepositoryServico repositoryServico)
        {
            RepositoryServico = repositoryServico;
        }
        public void Cadastrar(Servico servico)
        {
             RepositoryServico.Create(servico);
        }

        public Servico CarregarRegistro(int id)
        {
            return RepositoryServico.Read(id);
        }

        public void Excluir(int id)
        {
            RepositoryServico.Delete(id);
        }

        public IEnumerable<Servico> Listagem(int? IdPetshop)
        {
            return RepositoryServico.Read();
        }
    }
}
