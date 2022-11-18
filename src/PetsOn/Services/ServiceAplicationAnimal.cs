using Domain.Interfaces;
using PetsOn.Domain.Entities;
using PetsOn.Models;
using PetsOn.Services.Interfaces;

namespace PetsOn.Services
{
    public class ServiceAplicationAnimal : IServiceAplicationAnimal
    {
        public readonly IServiceAnimal ServiceAnimal;

        public ServiceAplicationAnimal(IServiceAnimal serviceAnimal)
        {
            ServiceAnimal = serviceAnimal;
        }

        public void Cadastrar(ClienteAnimalViewModel animal)
        {
            Animal item = new()
            {
                Nome_Animal = animal.Nome_Animal,
                Idade = animal.Idade,
                Raca = animal.Raca,
                Observacao = animal.Observacao,
                Id_Cliente = (int)animal.Codigo_Cliente
            };

            ServiceAnimal.Cadastrar(item);
        }
    }
}