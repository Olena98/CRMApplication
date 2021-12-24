using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApplications
{
    class ClientService
    {
        public static List<Client> Clients = new List<Client>();
        public static void AddNewClient(Client clients)
        {
            Clients.Add(clients);
        }
        public static List<Client> GetClientByName(string name) 
        {
            return Clients.Where(c => c.ClientName.ToUpper().Contains(name)).ToList();
        }
        public static List<Client> GetClientBySurname(string surname) 
        {
            return Clients.Where(c => c.ClientSurname.ToUpper().Contains(surname)).ToList();
        }
        public static List<Client> GetClientByLastname(string lastname) 
        {
            return Clients.Where(c => c.ClientLastname.ToUpper().Contains(lastname)).ToList();
        }
        public static List<Client> GetClientByPhone(string phone) 
        {
            return Clients.Where(c => c.PhoneNumber.ToUpper().Contains(phone)).ToList();
        }
        public static List<Client> GetClientByEmail(string email) 
        {
            return Clients.Where(c => c.Email.ToUpper().Contains(email)).ToList();
        }
        public static List<Client> GetClientByGuid(Guid guid) 
        {
            return Clients.Where(c => c.Id == guid).ToList();
        }
    }
}
