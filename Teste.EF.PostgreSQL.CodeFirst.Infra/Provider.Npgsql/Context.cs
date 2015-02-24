#region Imports (8)

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Teste.EF.PostgreSQL.CodeFirst.Domain.Entities;

#endregion Imports (8)

namespace Teste.EF.PostgreSQL.CodeFirst.Infra.Provider.Npgsql
{
    public class Context : DbContext
    {
        #region Properties of Context (1)

        public DbSet<Product> Product { get; set; }

        #endregion Properties of Context (1)

        #region Constructors of Context (1)

        public Context() : base("name=Connection")
        {
        }

        #endregion Constructors of Context (1)

        #region Methods of Context (1)

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.CreateIfNotExists();
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Entity<Product>().ToTable("Product", "public");

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        #endregion Methods of Context (1)
    }
}
