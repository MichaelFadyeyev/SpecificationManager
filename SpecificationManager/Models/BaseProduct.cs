using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationManager.Models
{
    public class BaseProduct
    {
        public string Article { set; get; }
        public string Name { set; get; }
        public string Code { set; get; } // Code format: [CategoryId] SupplierId 

        public BaseProduct() { }
        public BaseProduct (string a, string n, string c)
        {
            Article = a;
            Name = n;
            Code = c;
        }
    }

}
