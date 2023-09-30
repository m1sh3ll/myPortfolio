using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.Models.Responses
{
    public class OrderDeleteResponse : Response
    {
        public Order Order { get; set; }
        public int LastOrderID { get; set; }
        public List<Order> NewOrdersList { get; set; }

    }
}
