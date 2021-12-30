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
            OrdersService.Orders = ReadXmlFile(xmlPath);
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
        public static List<Order> ReadXmlFile(string xmlPath)
        {

            List<Order> orders = new List<Order>();
            var doc = new XmlDocument();

            if (File.Exists(xmlPath))
            {
                doc.Load(xmlPath);
            }
            else
            {
                File.Create(xmlPath);
                doc.CreateElement("orders");
            }
            var xRoot = doc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {

                if (xnode.Attributes.Count > 0)
                {
                    Order order = new Order();

                    XmlNode attrGuid = xnode.Attributes.GetNamedItem("guid");
                    if (attrGuid != null)
                    {
                        order.Id = Guid.Parse(attrGuid.Value);
                    }
                    XmlNode attrOrderNumber = xnode.Attributes.GetNamedItem("orderNumber");
                    if (attrOrderNumber != null)
                    {
                        order.OrderNumber = Convert.ToInt32(attrOrderNumber.Value);
                    }
                    XmlNode attrOrderDate = xnode.Attributes.GetNamedItem("orderDate");
                    if (attrOrderDate != null)
                    {
                        order.OrderDate = DateTime.Parse(attrOrderDate.Value);
                    }
                    XmlNode attrOrderStatus = xnode.Attributes.GetNamedItem("orderStatus");
                    if (attrOrderStatus != null)
                    {
                        order.Status = (Order.OrderStatus)Enum.Parse(typeof(Order.OrderStatus),attrOrderStatus.Value);
                    }
                    XmlNode attrClientPhone = xnode.Attributes.GetNamedItem("clientPhone");
                    if (attrClientPhone != null)
                    {
                        order.ClientPhone = attrClientPhone.Value;
                    }
                    XmlNode attrClientGuid = xnode.Attributes.GetNamedItem("clientGuid");
                    if (attrClientGuid != null)
                    {
                        order.ClientGuid = Guid.Parse(attrClientGuid.Value);
                    }
                    XmlNode attrProductGuid = xnode.Attributes.GetNamedItem("productGuid");
                    if(attrProductGuid != null)
                    {
                        order.ProductGuid = Guid.Parse(attrProductGuid.Value);
                    }

                    orders.Add(order);
                }
            }
            return orders;
        }
    }
}
