using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApplications
{
    class ProductService

    {
        public static void AddNewProduct(Product products)
        {
            ProductsDataBase.AddNewProduct(products);

           
        }
    }
}
