using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApplications
{
    class OrdersService

    {
        public static List<Order> Orders = new List<Order>();

        public static void AddNewOrder(Order order)
        {
            Orders.Add(order);
            OrdersDataBase.SaveAllOrders();
        }
        public static List<Order> GetOrderByNumber(int number)
        {
            return Orders.Where(o => o.OrderNumber == number).ToList();
        }
        public static List<Order> GetOrderByDate(DateTime date)
        {
            return Orders.Where(o => o.OrderDate == date).ToList();
        }
        public static List<Order>GetOrdersByStatus(Order.OrderStatus status) 
        {
            return Orders.Where(o => o.Status == status).ToList();
        }
        
            

    }
}
