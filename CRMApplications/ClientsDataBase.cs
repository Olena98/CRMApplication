using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace CRMApplications
{
    class ClientsDataBase
    {
        private static string xmlPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "clientWF.xml");

        public static void Initialize()
        {
           
            ClientService.Clients = ReadXmlFile(xmlPath);
        }

        public static void SaveAllClient()
        {
            if (ClientService.Clients == null || ClientService.Clients.Count == 0)
            {
                return;
            }
            XmlDocument xDoc = new XmlDocument();
            XmlNode rootElement = xDoc.CreateNode(XmlNodeType.Element, "clients", string.Empty);
            xDoc.AppendChild(rootElement);

            foreach (var client in ClientService.Clients)
            {
                AppendClientNode(rootElement, client);
            }

            xDoc.Save(xmlPath);
        }
        private static void AppendClientNode(XmlNode parentNode, Client client)
        {
            XmlElement productElem = parentNode.OwnerDocument.CreateElement("client");
            productElem.SetAttribute("guid", client.Id.ToString());
            productElem.SetAttribute("clientName", client.ClientName);
            productElem.SetAttribute("clientSurname",client.ClientSurname);
            productElem.SetAttribute("clientLastname", client.ClientLastname);
            productElem.SetAttribute("clientPhone", client.PhoneNumber);
            productElem.SetAttribute("clientEmail", client.Email);

            parentNode.AppendChild(productElem);
        }
        public static List<Client> ReadXmlFile(string xmlPath)
        {

            List<Client> clients = new List<Client>();
            var doc = new XmlDocument();

            if (File.Exists(xmlPath))
            {
                doc.Load(xmlPath);
            }
            else
            {
                File.Create(xmlPath);
                doc.CreateElement("clients");
            }
            var xRoot = doc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {

                if (xnode.Attributes.Count > 0)
                {
                    Client client = new Client();

                    XmlNode attrClientName = xnode.Attributes.GetNamedItem("clientName");
                    if (attrClientName != null)
                    {
                        client.ClientName = attrClientName.Value;
                    }
                    XmlNode attrSurname = xnode.Attributes.GetNamedItem("clientSurname");
                    if (attrSurname != null)
                    {
                        client.ClientSurname = attrSurname.Value;
                    }
                    XmlNode attrLastname = xnode.Attributes.GetNamedItem("clientLastname");
                    if (attrLastname != null)
                    {
                        client.ClientLastname = attrLastname.Value;
                    }
                    XmlNode attrPhone = xnode.Attributes.GetNamedItem("clientPhone");
                    if (attrPhone != null)
                    {
                        client.PhoneNumber = attrPhone.Value;
                    }
                    XmlNode attrEmail = xnode.Attributes.GetNamedItem("clientEmail");
                    if (attrEmail != null)
                    {
                        client.Email = attrEmail.Value;
                    }
                    XmlNode attrGuid = xnode.Attributes.GetNamedItem("guid");
                    if (attrGuid != null)
                    {
                        client.Id = Guid.Parse(attrGuid.Value);
                    }

                    clients.Add(client);
                }
            }
            return clients;
        }
    }
}

    

