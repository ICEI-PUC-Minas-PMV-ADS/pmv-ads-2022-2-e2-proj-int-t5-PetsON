
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PetsOn.Domain.Repository
{
    public interface IRepository<TEntidade>
        where TEntidade: class
    {
        void Create(TEntidade Entity);
        TEntidade Read(int id);
        void Delete(int id);
        IEnumerable<TEntidade> Read();
        DbSet<TEntidade> GetDbSet();
    }
}
