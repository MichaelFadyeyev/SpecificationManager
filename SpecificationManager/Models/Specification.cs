using System.Collections.Generic;
using System.Linq;

using SpecificationManager.Models.Settings;

namespace SpecificationManager.Models
{
    public class Specification
    {
        public List<Supplier> Suppliers { get; set; }
        public string Article { get; set; }

        public Specification()
        {
            Suppliers = new List<Supplier>();
            foreach (var item in SuppliersSetting.Naming)
            {
                Suppliers.Add(new Supplier(item.Key, item.Value));
            }
        }

        public Product FindProduct(string supplierId, string article)
        {
            //var supplier = Suppliers.FirstOrDefault(s => s.SupplierId == supplierId);
            //if (supplier == null) return null;
            //var product = supplier.Products.FirstOrDefault(s => s.Article == article);

            return Suppliers.FirstOrDefault(s => s.SupplierId == supplierId)
                .Products.FirstOrDefault(s => s.Article == article);
        }

        public void SumProducts(Product a, Product b)
        {
            a.Quantity = (float.Parse(a.Quantity) + float.Parse(b.Quantity)).ToString();
        }
    }
}
