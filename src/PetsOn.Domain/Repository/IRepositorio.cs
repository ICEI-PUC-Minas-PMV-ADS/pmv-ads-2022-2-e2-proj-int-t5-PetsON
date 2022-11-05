
namespace PetsOn.Domain.Repository
{
    public interface IRepositorio<TEntidade>
        where TEntidade: class
    {
        void Create(TEntidade Entity);
        TEntidade Read(int id);
        void Delete(int id);
        IEnumerable<TEntidade> Read();
    }
}
