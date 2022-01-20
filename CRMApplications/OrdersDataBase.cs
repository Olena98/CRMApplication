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
            XmlElement orderElem = parentNode.OwnerDocument.CreateElement("order");
            orderElem.SetAttribute("guid", order.Id.ToString());
            orderElem.SetAttribute("orderNumber", order.OrderNumber.ToString());
            orderElem.SetAttribute("orderStatus", order.Status.ToString());
            orderElem.SetAttribute("orderDate", order.OrderDate.ToString());
            orderElem.SetAttribute("clientPhone", order.ClientPhone);
            orderElem.SetAttribute("clientGuid", order.ClientGuid.ToString());
            orderElem.SetAttribute("productGuid", order.ProductGuid.ToString());

            AddChangeEntriesNode(orderElem, order.ChangesEntries);
            parentNode.AppendChild(orderElem);
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
                    var changeEntries = new List<Order.ChangeEntry>();
                    foreach (XmlNode storyNode in xnode.ChildNodes)
                    {
                        if (storyNode.Name.Equals("story"))
                        {
                            var entry = new Order.ChangeEntry();
                            entry.Status = (Order.OrderStatus)Enum.Parse(typeof(Order.OrderStatus), storyNode.Attributes["status"].Value);
                            entry.Date = DateTime.Parse(storyNode.Attributes["date"].Value);
                            changeEntries.Add(entry);
                        }
                    }

                    order.ChangesEntries = changeEntries;

                    orders.Add(order);
                }
            }
            return orders;
        }
        public static void AddChangeEntriesNode(XmlNode orderNode, List<Order.ChangeEntry> entries)
        {
            if (entries == null || entries.Count == 0)
            {
                return;
            }

            foreach (var entry in entries)
            {
                var changeEntry = orderNode.OwnerDocument.CreateElement("story");
                changeEntry.SetAttribute("date", entry.Date.ToString());
                changeEntry.SetAttribute("status", entry.Status.ToString());
                orderNode.AppendChild(changeEntry);
            }

        }
    }
}
