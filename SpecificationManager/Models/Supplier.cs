using System.Collections.Generic;


namespace SpecificationManager.Models
{
    public class Supplier
    {
        public string SupplierId { get; set; }
        public string Name { get; }
        public List<Product> Products { get; set; }

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
