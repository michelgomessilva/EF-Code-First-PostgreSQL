using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;

namespace Teste.EF.PostgreSQL.CodeFirst.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Vai criar o produto.........");
            System.Console.ReadKey();
            System.Console.Write("Start: " + DateTime.Now.ToString());
            for (int i = 0; i < 10000; i++)
            {
                var nameProduct = "Teste nome Produto= " + Convert.ToString(new Random().Next(10000));
                if (ProductApplication.Create(nameProduct))
                    System.Console.Write(".");
                    //System.Console.Write("Inseriu o produto= " + nameProduct);
                else
                    System.Console.Write("NÃO Inseriu o produto!");                
            }
            System.Console.Write("End: " + DateTime.Now.ToString());

            System.Console.Write("Start: " + DateTime.Now.ToString());

            var product = ProductApplication.GetByName("9bfaa575-11ce-4e89-affd-354af1daa045");
            System.Console.Write(Convert.ToString(product.Id + " - " + product.Name));

            System.Console.Write("End: " + DateTime.Now.ToString());

            System.Console.ReadKey();
        }
    }
}
