using Domain.Interfaces;
using PetsOn.Domain.Entities;
using PetsOn.Models;
using PetsOn.Services.Interfaces;

namespace PetsOn.Services
{
    public class ServiceAplicationPetshop : IServiceAplicationPetshop
    {
        public readonly IServicePetshop ServicePetshop;

        public ServiceAplicationPetshop(IServicePetshop servicePetshop)
        {
            ServicePetshop = servicePetshop;
        }
        public void Cadastrar(UsuarioPetshopViewModel petshop)
        {
            Petshop item = new()
            {
                Codigo = petshop.Codigo_Petshop,
                Nome_Empresa = petshop.Nome_Empresa,
                Cnpj = petshop.Cnpj,
                Web_Site = petshop.Web_Site,
                Descricao = petshop.Descricao
            };

            ServicePetshop.Cadastrar(item);
        }

    }
}
