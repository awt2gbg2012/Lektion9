using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Lektion9.Models.Entities;

namespace Lektion9.Models.Contexts
{
    public class EFContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}