using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.Models.Responses
{
    public class DisplayAllResponse : Response

    {
        public List<Order> AllOrdersList { get; set; }


    }
}
