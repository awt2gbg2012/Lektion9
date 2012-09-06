using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion9.Models.Entities;

namespace Lektion9._Repitition
{
    public class Repitition
    {
        public void MyMethod()
        {
            // Skriv interface 

            // Product innehåller en property Name och en property Price - 
            // Hur använder vi Repository.Products och Linq för att plocka
            // fram en sorterad lista av produkter med pris högre än 50?
            var products = Repository.Products.Where(p => p.Price > 50M).OrderBy(p => p.Name).ToList();

            // Hur testar vi IDName?
        }
        
    }

    public class GiveMeAnInterface
    {
        public int MyData { get; set;}
        public string PrettyPrinter() {return "I want an interface!";}
        public void Process(int i) { /* Processing Data */ }
    }

    public class IDName
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
    }












    public class Repository
    {
        public static List<Product> Products
        {
            get
            {
                return new List<Product>() {
                    new Product { Name = "Football", Price = 25 },
                    new Product { Name = "Surf board", Price = 179 },
                    new Product { Name = "Running shoes", Price = 95 }
                };
            }
        }
    }

    public interface IGiveMeAnInterface
    {
        int MyData { get; set; }
        string PrettyPrinter();
        void Process(int i);
    }
}