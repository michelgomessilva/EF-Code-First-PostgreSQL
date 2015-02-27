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
        private static ProductService _productService;

        public ProductApplication()
        {
            _productService = new ProductService(ProductRepository.GetInstance());
        }

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

        public static Product GetByName(string name)
        {
            ProductService productService = new ProductService(ProductRepository.GetInstance());
            return productService.GetByName(name);
        }

        public bool CreateAll(string name)
        {
            var ret = false;
            var products = new List<Product>();
            for (int i = 0; i < 10000; i++)
            {
                var product = new Product(Guid.NewGuid(), name, DateTime.UtcNow);
                products.Add(product);
                if (i % 1000 == 0 && i != 0)
                {
                    ret = _productService.CreateAll(products);
                    products = new List<Product>();
                }
            }
            return ret;
        }
        #endregion Methods of ProductApplication (1)
    }
}
