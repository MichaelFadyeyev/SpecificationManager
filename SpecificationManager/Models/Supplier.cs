using System;
using System.Collections.Generic;


namespace SpecificationManager.Models
{
    [Serializable]
    public class Supplier
    {
        public string SupplierId { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public Supplier() { }
        public Supplier(string name)
        {
            Name = name;
            Products = new List<Product>();
        }

        public Supplier(string supplierId, string name)
        {
            SupplierId = supplierId;
            Name = name;
            Products = new List<Product>();
        }
    }
}
