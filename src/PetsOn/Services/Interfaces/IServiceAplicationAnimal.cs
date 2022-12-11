using PetsOn.Domain.Entities;
using PetsOn.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PetsOn.Services.Interfaces
{
    public interface IServiceAplicationAnimal
    {
        void Cadastrar(AnimalViewModel animal);
        IEnumerable<AnimalViewModel> Listagem(int? IdPetShop);
        IEnumerable<SelectListItem> ListaAnimaisDropDownList();
        IEnumerable<AnimalViewModel> ListagemPetsCliente(int CodigoCliente);
        AnimalViewModel CarregarRegistro(int codigoAnimal);
        void Excluir(int id);
        
    }
}
