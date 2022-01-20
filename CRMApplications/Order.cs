using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApplications
{
    class Order
    {
        public Guid Id { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public string ClientPhone { get; set; }
        public Guid ClientGuid { get; set; }
        public Guid ProductGuid { get; set; }
        public List<ChangeEntry> ChangesEntries { get; set; }
        public class ChangeEntry
        {
            public DateTime Date { get; set; }
            public OrderStatus Status { get; set; }
        }

        public enum OrderStatus 
        {
            New,
            IsMakingUp,
            Sent,
            Paid,
            Canceled
        }
    }
}
