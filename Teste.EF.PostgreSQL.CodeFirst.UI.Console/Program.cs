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
            var nameProduct = "Teste nome Produto" + Convert.ToString(new Random().Next(10000));
            if (ProductApplication.Create(nameProduct))
                System.Console.Write("Inseriu o produto= " + nameProduct);
            else
                System.Console.Write("NÃO Inseriu o produto!");

            System.Console.ReadKey();
        }
    }
}
