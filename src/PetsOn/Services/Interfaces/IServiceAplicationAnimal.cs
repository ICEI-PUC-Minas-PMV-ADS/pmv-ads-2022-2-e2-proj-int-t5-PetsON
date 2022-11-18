using PetsOn.Domain.Entities;
using PetsOn.Models;

namespace PetsOn.Services.Interfaces
{
    public interface IServiceAplicationAnimal
    {
        void Cadastrar(ClienteAnimalViewModel animal);
    }
}
