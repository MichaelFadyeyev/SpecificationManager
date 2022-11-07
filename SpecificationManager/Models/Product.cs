using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationManager.Models
{
    [Serializable]
    public class Product : BaseProduct
    {
        public string Quantity { set; get; }
        public string Units { set; get; }


        public Product() : base() { }

        public Product(string a, string n, string q, string u, string c) : base (a, n, c)
        {
            Quantity = q;
            Units = u;
        }
    }
}
