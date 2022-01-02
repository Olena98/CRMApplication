using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApplications
{
    class UniqueNumericNumberHelper
    {
        public static int GetUniqueProductNumericNumber() 
        {
            var random = new Random();
            int randomNumber = random.Next(0, 20000000);
            while (ProductService.GetProductByNumber(randomNumber).Count > 0)
            {
                randomNumber = random.Next(0, 20000000);
                
            }
            return randomNumber;
        }
        public static int GetUniqueOrderNumericNumber() 
        {
            var random = new Random();
            int randomNumber = random.Next(0, 20000000);
            while (OrdersService.GetOrderByNumber(randomNumber).Count > 0)
            {
                randomNumber = random.Next(0, 20000000);
               
            }
            return randomNumber;
        }
    }
}
