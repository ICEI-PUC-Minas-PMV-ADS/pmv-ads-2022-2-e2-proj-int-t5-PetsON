using PetsOn.Domain.Entities;
using PetsOn.Models;
using System.Web.Mvc;

namespace PetsOn.Services.Interfaces
{
    public interface IServiceAplicationAnimal
    {
        void Cadastrar(AnimalViewModel animal);
        IEnumerable<AnimalViewModel> Listagem();
        IEnumerable<SelectListItem> ListaAnimaisDropDownList();
        IEnumerable<AnimalViewModel> ListagemPetsCliente(int CodigoCliente);
        AnimalViewModel CarregarRegistro(int codigoAnimal);
        void Excluir(int id);
        
    }
}
