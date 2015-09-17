using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace GFX.Core
{
    public class FakeRepository<T>
        : IRepository<T>
        where T : class, new()
    {

        private ICollection<T> data = new HashSet<T>();

        public virtual IQueryable<T> Query(Func<T, bool> predicate)
        {
            return data.Where(predicate).AsQueryable<T>();
        }

        public virtual T Add(T item)
        {
            data.Add(item);
            return item;
        }

        public virtual T Remove(T item)
        {
            if (data.Remove(item))
            {
                return item;
            }
            return default(T);
        }

        public virtual int SaveChanges()
        {
            return 0;
        }

        public DbContext Context
        {
            get
            {
                return null;
            }
            set
            {
                //
            }
        }

        public void Dispose()
        {
            // 
        }
    }
}