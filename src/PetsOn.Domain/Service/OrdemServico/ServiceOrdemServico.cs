using Domain.Interfaces;
using PetsOn.Domain.Entities;
using PetsOn.Domain.Repository;

namespace Domain.Service
{
    public class ServiceOrdemServico : IServiceOrdemServico
    {
        IRepositoryOrdemServico RepositoryOrdemServico;

        public ServiceOrdemServico(
            IRepositoryOrdemServico repositoryOrdemServico)
        {
            RepositoryOrdemServico = repositoryOrdemServico;
        }
        public void Cadastrar(OrdemServico OrdemServico)
        {
             RepositoryOrdemServico.Create(OrdemServico);
        }

        public OrdemServico CarregarRegistro(int id)
        {
            return RepositoryOrdemServico.Read(id);
        }

        public void Excluir(int id)
        {
            RepositoryOrdemServico.Delete(id);
        }

        public IEnumerable<OrdemServico> Listagem(int? IdPetshop)
        {
            return RepositoryOrdemServico.Read();
        }
    }
}
