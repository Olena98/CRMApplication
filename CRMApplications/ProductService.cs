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
        public static List<Product> GetProductByName(string name) 
        {
            return Products.Where(p => p.ProductName.ToUpper().Contains(name)).ToList();
        }
        public static List<Product> GetProductByDescription(string description)
        {
            return Products.Where(p => p.ProductDescription.ToUpper().Contains(description)).ToList();
        }
        public static List<Product> GetProductByPrice(decimal price) 
        {
            return Products.Where(p => p.Price == price).ToList();
        }
        public static List<Product> GetProductByNumber(int number) 
        {
            return Products.Where(p => p.ProductNumber == number).ToList();
        }
        public static List<Product> GetProductByExistence(bool existence) 
        {
            return Products.Where(p => p.Existence == existence).ToList();
        }
        public static List<Product> GetProductByGuid(Guid guid) 
        {
            return Products.Where(p => p.Id == guid).ToList();
        }
    }
}
