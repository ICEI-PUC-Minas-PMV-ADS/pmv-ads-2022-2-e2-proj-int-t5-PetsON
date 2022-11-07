using Domain.Interfaces;
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

        public IEnumerable<Animal> Listagem()
        {
            return RepositoryAnimal.Read();
        }
    }
}
