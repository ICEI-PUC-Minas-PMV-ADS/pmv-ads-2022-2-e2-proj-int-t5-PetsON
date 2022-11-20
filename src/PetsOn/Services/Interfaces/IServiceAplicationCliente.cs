using PetsOn.Domain.Entities;
using PetsOn.Models;

namespace PetsOn.Services.Interfaces
{
    public interface IServiceAplicationCliente
    {
        void Cadastrar(ClienteAnimalViewModel cliente);
        int RetornarClienteId(string CPF);
    }
}
