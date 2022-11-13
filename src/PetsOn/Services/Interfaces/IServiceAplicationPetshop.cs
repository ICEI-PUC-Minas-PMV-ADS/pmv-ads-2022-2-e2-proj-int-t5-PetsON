using PetsOn.Domain.Entities;
using PetsOn.Models;

namespace PetsOn.Services.Interfaces
{
    public interface IServiceAplicationPetshop
    {
        void Cadastrar(UsuarioPetshopViewModel petshop);
        int RetornarPetshopId(string CNPJ);
    }
}
