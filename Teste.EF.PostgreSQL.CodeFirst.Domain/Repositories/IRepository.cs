using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.EF.PostgreSQL.CodeFirst.Domain.Repositories
{
    public interface IRepository<T>
    {
        T GetByKey(Guid key);
        IList<T> GetList(T entity);
        void Add(T entity);
        void Edit(T entity);
        void Remove(T entity);
        
    }
}
