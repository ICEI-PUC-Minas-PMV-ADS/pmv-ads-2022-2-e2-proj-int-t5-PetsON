using Domain.Interfaces;
using PetsOn.Domain.Entities;
using PetsOn.Models;
using PetsOn.Services.Interfaces;

namespace PetsOn.Services
{
    public class ServiceAplicationCliente : IServiceAplicationCliente
    {
        public readonly IServiceCliente ServiceCliente;
        private readonly IServiceAplicationAnimal ServiceAplicationAnimal;

        public ServiceAplicationCliente(
            IServiceCliente serviceCliente,
            IServiceAplicationAnimal serviceAplicationAnimal)
        {
            ServiceCliente = serviceCliente;
            ServiceAplicationAnimal = serviceAplicationAnimal;    
        }
        public void Cadastrar(ClienteAnimalViewModel cliente)
        {
            Cliente item = new()
            {
                Nome = cliente.Nome,
                Cpf = cliente.Cpf,
                Email = cliente.Email,
                Celular = cliente.Celular,
                Endereco = cliente.Endereco,
            };

            ServiceCliente.Cadastrar(item);
            cliente.Codigo_Cliente = RetornarClienteId(cliente.Cpf); 
            ServiceAplicationAnimal.Cadastrar(cliente);
        }

        public int RetornarClienteId(string CPF)
        {
            var Cliente = ServiceCliente.Listagem().Where(x => x.Cpf == CPF).FirstOrDefault();
            return (int)Cliente.Id;
        }
    }
}
