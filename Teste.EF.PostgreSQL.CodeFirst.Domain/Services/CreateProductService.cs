using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.EF.PostgreSQL.CodeFirst.Domain.Entities;

namespace Teste.EF.PostgreSQL.CodeFirst.Domain.Services
{
    public class CreateProductService
    {
        public static Product Create(Product product)
        {
            return new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product name (" + Convert.ToString(new Random().Next(10000)) + ")",
                CreatedDate = DateTime.UtcNow
            };
        }
    }
}
