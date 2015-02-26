#region Imports (6)

using ServiceStack.OrmLite;
using ServiceStack.OrmLite.PostgreSQL;
using System;
using System.Collections.Generic;
using Teste.EF.PostgreSQL.CodeFirst.Domain.Entities;
using Teste.EF.PostgreSQL.CodeFirst.Domain.Repositories;

#endregion Imports (6)

namespace Teste.EF.PostgreSQL.CodeFirst.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        #region Members of ProductRepository (2)
        private static ProductRepository _instance;
        private static OrmLiteConnectionFactory _connectionFactory;

        #endregion Members of ProductRepository (2)

        #region Constructors of ProductRepository (1)

        public ProductRepository()
        {
            _connectionFactory = new OrmLiteConnectionFactory("Server=localhost;Port=5432;User Id=teste; Password=teste; Database=Teste",
                                                PostgreSQLDialectProvider.Instance);
        }

        #endregion Constructors of ProductRepository (1)

        #region Methods of ProductRepository (7)

        public void Add(Product entity)
        {
            try
            {
                using (var conn = _connectionFactory.Open())
                {
                    conn.CreateTableIfNotExists<Product>();
                    conn.Save(entity);
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

        public Product GetByName(string key)
        {
            using (var conn = _connectionFactory.Open())
            {
                var product = conn.Select<Product>(p => p.Name == key);
                return product[0];
            }
        }

        public static ProductRepository GetInstance()
        {
            return _instance ?? (_instance = new ProductRepository());
        }

        public IList<Product> GetList(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Product entity)
        {
            throw new NotImplementedException();
        }

        #endregion Methods of ProductRepository (7)
    }
}
