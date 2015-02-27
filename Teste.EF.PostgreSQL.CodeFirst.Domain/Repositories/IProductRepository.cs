using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Teste.EF.PostgreSQL.CodeFirst.Domain.Entities;

namespace Teste.EF.PostgreSQL.CodeFirst.Domain.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetByName(string name);
        void AddBulk(IEnumerable<Product> products);
    }
}
