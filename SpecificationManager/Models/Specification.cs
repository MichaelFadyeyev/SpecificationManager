using System.Collections.Generic;

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
    }
}
