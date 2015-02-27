#region Imports (7)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.EF.PostgreSQL.CodeFirst.Domain.Entities;
using Teste.EF.PostgreSQL.CodeFirst.Domain.Repositories;

#endregion Imports (7)

namespace Teste.EF.PostgreSQL.CodeFirst.Domain.Services
{
    public class ProductService
    {
        #region Members of ProductService (1)
        private readonly IProductRepository _repository;

        #endregion Members of ProductService (1)

        #region Constructors of ProductService (1)

        public ProductService(IProductRepository repository)
        {
            this._repository = repository;
        }

        #endregion Constructors of ProductService (1)

        #region Methods of ProductService (3)

        public bool Create(Product product)
        {
            try
            {
                _repository.Add(product);
                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public bool CreateAll(List<Product> products)
        {
            try
            {
                _repository.AddBulk(products);
                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public Product GetByName(string name)
        {
            return _repository.GetByName(name);
        }

        #endregion Methods of ProductService (3)
    }
}
