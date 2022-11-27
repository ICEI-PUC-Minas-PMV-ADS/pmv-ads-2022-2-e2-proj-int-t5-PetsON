using Domain.Interfaces;
using PetsOn.Domain.Entities;
using PetsOn.Models;
using PetsOn.Services.Interfaces;

namespace PetsOn.Services
{
    public class ServiceAplicationUsuario : IServiceAplicationUsuario
    {
        public readonly IServiceUsuario ServiceUsuario;

        public ServiceAplicationUsuario(IServiceUsuario serviceUsuario)
        {
            ServiceUsuario = serviceUsuario;
        }

        public void Cadastrar(UsuarioPetshopViewModel usuario)
        {
            Usuario item = new()
            {
                Nome_Usuario = $"{usuario.Nome} {usuario.Sobrenome}",
                Email = usuario.Email,
                Senha = usuario.Senha,
                Id_Petshop = (int)usuario.Codigo_Petshop
            };

            ServiceUsuario.Cadastrar(item);
        }

        public Usuario RetornarDadosUsuario(string email, string senha)
        {
            return ServiceUsuario.Listagem(null).Where(x => x.Email == email && x.Senha.ToUpper() == senha.ToUpper()).FirstOrDefault();
        }

        public bool ValidarLogin(string email, string senha)
        {
            return ServiceUsuario.ValidarLogin(email, senha);
        }
    }
}