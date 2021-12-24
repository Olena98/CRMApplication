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
    }
}
