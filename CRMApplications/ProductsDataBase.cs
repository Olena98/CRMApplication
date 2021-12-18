using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApplications
{
    class ProductsDataBase
    {
      public static  List<Product> Products { get; private set; }
        
      public static void AddNewProduct(Product product) 
      {
            foreach (Product p in Products)
            {
                Console.WriteLine("Product name: " + p.ProductName);
                Console.WriteLine("Description: " + p.ProductDescription);
                Console.WriteLine("Price: " + p.Price);
                Console.WriteLine("Product number: " + p.ProductNumber);
                Console.WriteLine("Existense: " + p.Existence);
                Console.WriteLine("Id: " + p.Id);
                Console.WriteLine();
            }
            Products.Add(product);
           
        } 
    }
}
