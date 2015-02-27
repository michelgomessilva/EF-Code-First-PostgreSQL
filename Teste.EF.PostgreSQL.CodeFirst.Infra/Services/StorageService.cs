using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using NpgsqlTypes;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.PostgreSQL;
using Teste.EF.PostgreSQL.CodeFirst.Domain.Entities;

namespace Teste.EF.PostgreSQL.CodeFirst.Infra.Services
{
    internal class StorageService
    {
        private static OrmLiteConnectionFactory _connectionFactory;

        public StorageService()
        {
            _connectionFactory = new OrmLiteConnectionFactory("Server=localhost;Port=5432;User Id=teste; Password=teste; Database=Teste", 
                                    PostgreSqlDialect.Provider);
        }

        public void AddBulk(StorageModel[] items)
        {
            using (var conn = _connectionFactory.Open())
            {
                conn.CreateTableIfNotExists<StorageModel>();
                var x = conn.CreateCommand();
                x.CommandText = "INSERT INTO product (nome, descricao) VALUES ('The Bourne Sanction', 'autor    => \"Robert Ludlums\", paginas     => 688, categoria  => ficção, dispositivo => Kindle, formato => ebook')";
                x.ExecuteNonQuery();
                //conn.InsertAll(items);
            }            
        }
    }

    internal abstract class StorageModel
    {
        protected StorageModel()
        {
            Id = Guid.NewGuid();
            Index = new Dictionary<string, string>();
            TimeStamp = DateTimeOffset.Now;
        }

        public Guid Id { get; set; }
        public IDictionary<string, string> Index { get; set; }
        public string Content { get; set; }
        public int TenantId { get; set; }
        public int Version { get; set; }
        public DateTimeOffset TimeStamp { get; set; }

    }

    internal sealed class ProductStorageModel : StorageModel
    {

        public ProductStorageModel(Product product)
        {
            Content = JsonConvert.SerializeObject(product);
            Index["ProductID"] = Convert.ToString(product.Id, CultureInfo.InvariantCulture);
            Version = product.Version;
        }
    }
}
