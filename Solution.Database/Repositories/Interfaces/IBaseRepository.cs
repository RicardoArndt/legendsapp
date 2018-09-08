using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Database.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(Func<T, bool> predicate);
        T Find(params object[] key);
        void Update(T obj);
        void SaveAll();
        void Add(T obj);
        void Excluir(Func<T, bool> predicate);
    }
}
