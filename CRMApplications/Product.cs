using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApplications
{
    class Product
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public int ProductNumber { get; set; }
        public bool Existence { get; set; }
        public Guid Id { get; set; }


    }
}
