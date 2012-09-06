using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lektion9.Models.Entities;

namespace Lektion9.Models.Repositories.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
        void Add(Product p);
        void Edit(Product p);
        void Remove(Product p);
        Product Get(Guid id);
    }
}
