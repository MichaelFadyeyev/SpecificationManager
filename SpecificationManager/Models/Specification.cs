using System;
using System.Collections.Generic;
using System.Linq;

namespace SpecificationManager.Models
{
    [Serializable]
    public class Specification
    {
        public List<Supplier> Suppliers { get; set; }
        public string Article { get; set; }

        public Specification() { }

        public Product FindProduct(string supplierId, string article)
        {
            //var supplier = Suppliers.FirstOrDefault(s => s.SupplierId == supplierId);
            //if (supplier == null) 
            //    return null;
            return Suppliers.FirstOrDefault(s => s.SupplierId == supplierId)
                .Products.FirstOrDefault(s => s.Article == article);
        }

        public void SumProducts(Product a, Product b)
        {
            a.Quantity = (float.Parse(a.Quantity) + float.Parse(b.Quantity)).ToString();
        }
    }
}
