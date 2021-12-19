using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApplications
{
    class ProductsDataBase
    {
        public static List<Product> Products { get; private set; } = new List<Product>();

        public static void AddNewProduct(Product product)
        {
            Products.Add(product);
        }
    }
}
