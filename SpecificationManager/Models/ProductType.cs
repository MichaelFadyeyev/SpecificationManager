using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationManager.Models
{
    public class ProductType : BaseProduct
    {
        public string Type_ { set; get; }

        public ProductType() { }

        public ProductType(string p, string a, string n, string c) : base (a, n, c)
        {
            Type_ = p;
        }
    }
}