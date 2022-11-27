using PetsOn.Domain.Entities;

namespace Domain.Interfaces
{
    public interface IServiceAnimal : IServiceCRUD<Animal>
    {
        IEnumerable<Animal> ListagemPetsCliente(int CodigoCliente);
    }
}
