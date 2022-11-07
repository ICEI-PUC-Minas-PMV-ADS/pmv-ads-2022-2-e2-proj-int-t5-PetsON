using Domain.Interfaces;
using PetsOn.Domain.Entities;
using PetsOn.Domain.Repository;


namespace Domain.Service
{
    public class ServiceCliente : IServiceCliente
    {
        IRepositoryCliente RepositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente)
        {
            RepositoryCliente = repositoryCliente;
        }
        public void Cadastrar(Cliente cliente)
        {
            RepositoryCliente.Create(cliente);
        }

        public Cliente CarregarRegistro(int id)
        {
            return RepositoryCliente.Read(id);
        }

        public void Excluir(int id)
        {
            RepositoryCliente.Delete(id);
        }

        public IEnumerable<Cliente> Listagem()
        {
            return RepositoryCliente.Read();
        }
    }
}
