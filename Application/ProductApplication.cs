#region Imports (7)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.EF.PostgreSQL.CodeFirst.Domain.Entities;
using Teste.EF.PostgreSQL.CodeFirst.Domain.Services;
using Teste.EF.PostgreSQL.CodeFirst.Infra.Repositories;

#endregion Imports (7)

namespace Application
{
    public class ProductApplication
    {
        #region Methods of ProductApplication (1)

        public static bool Create(string name)
        {
            // Aqui pode entrar a validação no server, talvez utilizar Specifications

            var product = new Product(Guid.NewGuid(), name, DateTime.UtcNow);
            var productService = new ProductService(ProductRepository.GetInstance());
            if (productService.Create(product))
                return true;
            return false;
        }

        #endregion Methods of ProductApplication (1)
    }
}
