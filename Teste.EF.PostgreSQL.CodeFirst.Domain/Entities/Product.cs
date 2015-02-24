#region Imports (5)

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion Imports (5)

namespace Teste.EF.PostgreSQL.CodeFirst.Domain.Entities
{
    [Table("Product", Schema = "public")]
    public class Product
    {
        #region Members of Product (3)
        private Guid _id;
        private string _name;
        private DateTime _createdDate;

        #endregion Members of Product (3)

        #region Properties of Product (3)

        public DateTime CreatedDate { get; set; }

        public Guid Id { get; set; }

        public string Name { get; set; }

        #endregion Properties of Product (3)

        #region Constructors of Product (1)

        public Product(Guid id, string name, DateTime createdDate)
        {
            this.Id = id;
            this.Name = name;
            this.CreatedDate = createdDate;
        }

        #endregion Constructors of Product (1)
    }
}
