#region Imports (7)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Teste.EF.PostgreSQL.CodeFirst.Domain.Entities;
using Teste.EF.PostgreSQL.CodeFirst.Domain.Repositories;

#endregion Imports (7)

namespace Teste.EF.PostgreSQL.CodeFirst.Infra.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private static ProductRepository _instance;

        #region Methods of ProductRepository (5)

        public static ProductRepository GetInstance()
        {
            return _instance ?? (_instance = new ProductRepository());
        }

        public void Add(Product entity)
        {
            try
            {
                using (var context = new Provider.Npgsql.Context())
                {
                    context.Product.Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        public void Edit(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product GetByKey(Guid key)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetList(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Product entity)
        {
            throw new NotImplementedException();
        }

        #endregion Methods of ProductRepository (5)
    }
}
