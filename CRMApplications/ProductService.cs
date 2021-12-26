using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApplications
{
    class ProductService

    {
        public static List<Product> Products = new List<Product>();

        public static void AddNewProduct(Product products)
        {
            Products.Add(products);
            
        }
    }
}
