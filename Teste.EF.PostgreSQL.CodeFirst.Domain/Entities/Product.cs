#region Imports (5)

using System;
using ServiceStack.DataAnnotations;

#endregion Imports (5)

namespace Teste.EF.PostgreSQL.CodeFirst.Domain.Entities
{
    [Alias("Produto")]
    public class Product
    {
        #region Members of Product (3)
        private Guid _id;
        private string _name;
        private DateTime _createdDate;

        #endregion Members of Product (3)

        #region Properties of Product (3)
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Alias("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        public int Version { get; set; }

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
