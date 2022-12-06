using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using PetsOn.Domain.Entities;
using PetsOn.Domain.Repository;


namespace Domain.Service
{
    public class ServiceAnimal : IServiceAnimal
    {
        IRepositoryAnimal RepositoryAnimal;

        public ServiceAnimal(IRepositoryAnimal repositoryAnimal)
        {
            RepositoryAnimal = repositoryAnimal;
        }
        public void Cadastrar(Animal animal)
        {
             RepositoryAnimal.Create(animal);
        }

        public Animal CarregarRegistro(int id)
        {
            return RepositoryAnimal.Read(id);
        }

        public void Excluir(int id)
        {
            RepositoryAnimal.Delete(id);
        }

        public IEnumerable<Animal> Listagem(int? IdPetShop)
        {
            return RepositoryAnimal.GetDbSet().Include(x => x.Cliente).AsNoTracking().Where(x=>x.Cliente.Id_Petshop==IdPetShop).ToList();
        }


        public IEnumerable<Animal> ListagemPetsCliente(int CodigoCliente)
        {
            return RepositoryAnimal.Read().Where(x => x.Id_Cliente == CodigoCliente);
        }
    }
}