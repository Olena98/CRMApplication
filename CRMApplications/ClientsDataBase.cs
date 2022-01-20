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
            XmlElement clientElem = parentNode.OwnerDocument.CreateElement("client");
            clientElem.SetAttribute("guid", client.Id.ToString());
            clientElem.SetAttribute("clientName", client.ClientName);
            clientElem.SetAttribute("clientSurname",client.ClientSurname);
            clientElem.SetAttribute("clientLastname", client.ClientLastname);
            clientElem.SetAttribute("clientPhone", client.PhoneNumber);
            clientElem.SetAttribute("clientEmail", client.Email);

            AddChangeEntriesNode(clientElem, client.ChangesEntries);
            parentNode.AppendChild(clientElem);
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
                    var changeEntries = new List<Client.ChangeEntry>();
                    foreach (XmlNode storyNode in xnode.ChildNodes)
                    {
                        if (storyNode.Name.Equals("story"))
                        {
                            var entry = new Client.ChangeEntry();
                            entry.Name = storyNode.Attributes["name"].Value;
                            entry.Surname = storyNode.Attributes["surname"].Value;
                            entry.PhoneNumber = storyNode.Attributes["phonenumber"].Value;
                            entry.Email = storyNode.Attributes["email"].Value;

                            changeEntries.Add(entry);
                        }
                    }

                    client.ChangesEntries = changeEntries;

                    clients.Add(client);
                }
            }
            return clients;
        }
        public static void AddChangeEntriesNode(XmlNode orderNode, List<Client.ChangeEntry> entries)
        {
            if (entries == null || entries.Count == 0)
            {
                return;
            }

            foreach (var entry in entries)
            {
                var changeEntry = orderNode.OwnerDocument.CreateElement("story");
                changeEntry.SetAttribute("name", entry.Name);
                changeEntry.SetAttribute("surname", entry.Surname);
                changeEntry.SetAttribute("phonenumber", entry.PhoneNumber);
                changeEntry.SetAttribute("email", entry.Email);

                orderNode.AppendChild(changeEntry);
            }

        }
    }
}

    

