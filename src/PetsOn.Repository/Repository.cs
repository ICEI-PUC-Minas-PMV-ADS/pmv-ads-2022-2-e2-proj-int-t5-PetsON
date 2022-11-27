using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetsOn.Domain.Entities;

namespace PetsOn.Repository
{
    public abstract class Repository<TEntidade> : DbContext, IRepository<TEntidade>
        where TEntidade : EntityBase, new()
    {

        protected DbContext Db;
        protected DbSet<TEntidade> DbSetContext;
        public Repository(DbContext dbContext)
        {
            Db = dbContext;
            DbSetContext = Db.Set<TEntidade>();
        }
        
        public void Create(TEntidade Entity)
        {
            if (Entity.Id == null)
            {
                DbSetContext.Add(Entity);
            }
            else
            {
                Db.Entry(Entity).State = EntityState.Modified;
            }
            Db.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            var ent = new TEntidade { Id = id };
            DbSetContext.Attach(ent);
            DbSetContext.Remove(ent);
            Db.SaveChanges();        
        }

        public DbSet<TEntidade> GetDbSet()
        {
            return DbSetContext;
        }

        public TEntidade Read(int id)
        {
            return DbSetContext.Where(x => x.Id == id).FirstOrDefault();
        }

        public virtual IEnumerable<TEntidade> Read()
        {
            return DbSetContext.AsNoTracking().ToList();
        }
    }
}
