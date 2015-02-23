using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.EF.PostgreSQL.CodeFirst.Domain.Entities;
using Teste.EF.PostgreSQL.CodeFirst.Domain.Repositories;

namespace Teste.EF.PostgreSQL.CodeFirst.Infra
{
    public class ProductRepository : IRepository<Product>
    {
        public Product GetByKey(Guid key)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetList(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
