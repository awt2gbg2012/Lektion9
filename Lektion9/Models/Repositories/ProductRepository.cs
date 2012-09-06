using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion9.Models.Repositories.Abstract;
using Lektion9.Models.Entities;

namespace Lektion9.Models.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _dbcontext = new List<Product>();
        
        public IQueryable<Product> Products { get { return _dbcontext.AsQueryable<Product>(); /* return _dbcontext.Products; */ } }
        public void Add(Product p) { _dbcontext.Add(p); /* _dbcontext.Add(p); _dbcontext.SaveChanges(); */ }
        public void Edit(Product p) { _dbcontext.Insert(_dbcontext.IndexOf(p), p); /* _db.Entry(entity).State = EntityState.Modified; _dbcontext.SaveChanges(); */ }
        public void Remove(Product p) { _dbcontext.Remove(p); /* _db.Entry(entity).State = EntityState.Deleted; _dbcontext.SaveChanges(); */ }
        public Product Get(Guid id) { return Products.Where(p => p.Id == id).FirstOrDefault(); }
    }
}