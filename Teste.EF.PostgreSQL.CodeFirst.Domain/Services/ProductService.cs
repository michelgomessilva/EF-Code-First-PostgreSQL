#region Imports (6)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.EF.PostgreSQL.CodeFirst.Domain.Entities;
using Teste.EF.PostgreSQL.CodeFirst.Domain.Repositories;

#endregion Imports (6)

namespace Teste.EF.PostgreSQL.CodeFirst.Domain.Services
{
    public class ProductService
    {
        private IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
            this._repository = repository;
        }

        #region Methods of CreateProductService (1)

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

        #endregion Methods of CreateProductService (1)
    }
}
