
namespace PetsOn.Domain.Repository
{
    public interface IRepository<TEntidade>
        where TEntidade: class
    {
        int Create(TEntidade Entity);
        TEntidade Read(int id);
        void Delete(int id);
        IEnumerable<TEntidade> Read();
    }
}
