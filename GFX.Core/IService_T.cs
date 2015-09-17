using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GFX.Core
{
    public interface IService<T> : IService where T : class
    {
        bool RequiresOwnDbContext { get; }

        IRepository<T> Repository { get; set; }

        IQueryable<T> All();
        IQueryable<T> Query(Func<T, bool> predicate);
        T Add(T item);
        void Remove(T item);

        int SaveChanges();
    }
}