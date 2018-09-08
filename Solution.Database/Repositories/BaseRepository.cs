using Solution.Database.Context;
using Solution.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Database.Repositories
{
    public class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : class
    {
        private BaseContext ctx = new BaseContext();

        public IQueryable<T> GetAll()
        {
            return ctx.Set<T>();
        }

        public IQueryable<T> Get(Func<T, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public T Find(params object[] key)
        {
            return ctx.Set<T>().Find(key);
        }

        public void Update(T obj)
        {
            ctx.Entry(obj).State = EntityState.Modified;
        }

        public void SaveAll()
        {
            ctx.SaveChanges();
        }

        public void Add(T obj)
        {
            ctx.Set<T>().Add(obj);
        }

        public void Excluir(Func<T, bool> predicate)
        {
            ctx.Set<T>().Where(predicate).ToList().ForEach(rmv => ctx.Set<T>().Remove(rmv));
        }

        public void Dispose()
        {
            ctx.Dispose();
        }
    }
}
