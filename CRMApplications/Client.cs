using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApplications
{
    class Client
    {
        public Guid Id { get; set; }
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string ClientLastname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<ChangeEntry> ChangesEntries { get; set; }
        public class ChangeEntry
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Surname { get; set; }

        }

    }
}
