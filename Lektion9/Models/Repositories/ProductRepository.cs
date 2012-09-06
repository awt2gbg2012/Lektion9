using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion9.Models.Repositories.Abstract;
using Lektion9.Models.Entities;
using Lektion9.Models.Contexts;
using System.Data;

namespace Lektion9.Models.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private EFContext _dbcontext = new EFContext();
        
        public IQueryable<Product> Products { get { return _dbcontext.Products; } }
        public void Add(Product p) { _dbcontext.Products.Add(p); _dbcontext.SaveChanges(); }
        public void Edit(Product p) { _dbcontext.Entry(p).State = EntityState.Modified; _dbcontext.SaveChanges(); }
        public void Remove(Product p) { _dbcontext.Entry(p).State = EntityState.Deleted; _dbcontext.SaveChanges(); }
        public Product Get(Guid id) { return Products.Where(p => p.Id == id).FirstOrDefault(); }
    }
}