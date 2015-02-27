using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;
using Teste.EF.PostgreSQL.CodeFirst.Domain.Entities;

namespace Teste.EF.PostgreSQL.CodeFirst.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Vai criar o produto.........");
            //System.Console.ReadKey();
            //System.Console.Write("Start: " + DateTime.Now.ToString());
            //for (int i = 0; i < 10000; i++)
            //{
            //    var nameProduct = "Teste nome Produto= " + Convert.ToString(new Random().Next(10000));
            //    ProductApplication.Create(nameProduct);
            //    //if ()
            //    //System.Console.Write(".");
            //    //System.Console.Write("Inseriu o produto= " + nameProduct);
            //    //else
            //    //  System.Console.Write("NÃO Inseriu o produto!");                
            //}
            //System.Console.WriteLine("End: " + DateTime.Now.ToString());

            //System.Console.ReadKey();

            //System.Console.WriteLine("Start: " + DateTime.Now.ToString());

            //var product = ProductApplication.GetByName("Teste nome Produto= 7819");
            //System.Console.WriteLine(Convert.ToString(product.Id + " - " + product.Name));

            //System.Console.Write("End: " + DateTime.Now.ToString());
            //System.Console.ReadKey();

            System.Console.WriteLine("Start: " + DateTime.Now.ToString());

            var productApp = new ProductApplication();
            productApp.CreateAll("Teste nome Produto Bulk= " + Convert.ToString(new Random().Next(10000)));

            System.Console.Write("End: " + DateTime.Now.ToString());

            System.Console.ReadKey();
        }
    }
}
