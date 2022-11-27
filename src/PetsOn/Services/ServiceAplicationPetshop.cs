using Domain.Interfaces;
using PetsOn.Domain.Entities;
using PetsOn.Models;
using PetsOn.Services.Interfaces;

namespace PetsOn.Services
{
    public class ServiceAplicationPetshop : IServiceAplicationPetshop
    {
        public readonly IServicePetshop ServicePetshop;
        private readonly IServiceAplicationUsuario ServiceAplicationUsuario;

        public ServiceAplicationPetshop(
            IServicePetshop servicePetshop, 
            IServiceAplicationUsuario serviceAplicationUsuario)
        {
            ServicePetshop = servicePetshop;
            ServiceAplicationUsuario = serviceAplicationUsuario;    
        }
        public void Cadastrar(UsuarioPetshopViewModel petshop)
        {
            Petshop item = new()
            {
                Nome_Empresa = petshop.Nome_Empresa,
                Cnpj = petshop.Cnpj,
                Web_Site = petshop.Web_Site,
                Descricao = petshop.Descricao,
            };

            ServicePetshop.Cadastrar(item);
            petshop.Codigo_Petshop = RetornarPetshopId(petshop.Cnpj); 
            ServiceAplicationUsuario.Cadastrar(petshop);
        }

        public int RetornarPetshopId(string CNPJ)
        {
            var Petshop = ServicePetshop.Listagem(null).Where(x => x.Cnpj == CNPJ).FirstOrDefault();
            return (int)Petshop.Id;
        }
    }
}
