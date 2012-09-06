using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion9.Models.Entities;
using Lektion9.Models.Repositories.Abstract;

namespace Lektion9.Models.Repositories
{
    public class FakeProductRepository : IProductRepository 
    {
        private List<Product> products = new List<Product>();
        public FakeProductRepository()
        {
            products = new List<Product>() {
                new Product { Name = "Football", Price = 25 },
                new Product { Name = "Surf board", Price = 179 },
                new Product { Name = "Running shoes", Price = 95 }
            };
        }

        public IQueryable<Product> Products { get { return products.AsQueryable<Product>(); } }
        public void Add(Product p) { products.Add(p); }
        public void Edit(Product p) { products.Insert(products.IndexOf(p), p); }
        public void Remove(Product p) { products.Remove(p); }
        public Product Get(Guid id) { return products.Where(p => p.Id == id).FirstOrDefault(); }
    }
}