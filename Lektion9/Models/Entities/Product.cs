using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lektion9.Models.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public string Category { get; set; }
    }
}