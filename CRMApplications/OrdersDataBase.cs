using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace CRMApplications
{
    class OrdersDataBase
    {
        private static string xmlPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "orderWf.xml");

        public static void Initialize() 
        {
           
        }
        public static void SaveAllOrders() 
        {
            if (OrdersService.Orders == null || OrdersService.Orders.Count == 0)
            {
                return;
            }
            XmlDocument xDoc = new XmlDocument();
            XmlNode rootElement = xDoc.CreateNode(XmlNodeType.Element, "orders", string.Empty);
            xDoc.AppendChild(rootElement);

            foreach (var order in OrdersService.Orders)
            {
                AppendOrderNode(rootElement, order);
            }

            xDoc.Save(xmlPath);
        }
        private static void AppendOrderNode(XmlNode parentNode, Order order)
        {
            XmlElement productElem = parentNode.OwnerDocument.CreateElement("order");
            productElem.SetAttribute("guid", order.Id.ToString());
            productElem.SetAttribute("orderNumber", order.OrderNumber.ToString());
            productElem.SetAttribute("orderStatus", order.Status.ToString());
            productElem.SetAttribute("orderDate", order.OrderDate.ToString());
            productElem.SetAttribute("clientPhone", order.ClientPhone);
            productElem.SetAttribute("clientGuid", order.ClientGuid.ToString());
            productElem.SetAttribute("productGuid", order.ProductGuid.ToString());

            parentNode.AppendChild(productElem);
        }
    }
}
