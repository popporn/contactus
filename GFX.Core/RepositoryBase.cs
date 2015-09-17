using System;
using System.Data.Entity;
using System.Linq;

namespace GFX.Core
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {

        public DbContext Context { get; set; }

        public IQueryable<T> Query(Func<T, bool> predicate)
        {
            return Context.Set<T>().Where(predicate).AsQueryable<T>();
        }

        public T Add(T item)
        {
            if (Context == null) return null;
            return Context.Set<T>().Add(item);
        }

        public T Remove(T item)
        {
            if (Context == null) return null;
            return Context.Set<T>().Remove(item);
        }

        public int SaveChanges()
        {
            if (Context == null) return -1;
            return Context.SaveChanges();
        }

        public void Dispose()
        {
            //
        }
    }
}