using PetsOn.Domain.Entities;
using PetsOn.Domain.Repository;
using Domain.Interfaces;

namespace Domain.Service
{ 
    public class ServiceUsuario : IServiceUsuario
    {
        IRepositoryUsuario RepositoryUsuario;

        public ServiceUsuario(IRepositoryUsuario repositoryUsuario)
        {
            RepositoryUsuario = repositoryUsuario;
        }
        public void Cadastrar(Usuario usuario)
        {
             RepositoryUsuario.Create(usuario);
        }

        public Usuario CarregarRegistro(int id)
        {
            return RepositoryUsuario.Read(id);
        }

        public void Excluir(int id)
        {
            RepositoryUsuario.Delete(id);
        }

        public IEnumerable<Usuario> Listagem(int? IdPetShop)
        {
            return RepositoryUsuario.Read();
        }

        public bool ValidarLogin(string email, string senha)
        {
            return RepositoryUsuario.ValidarLogin(email, senha);
        }
    }
}
