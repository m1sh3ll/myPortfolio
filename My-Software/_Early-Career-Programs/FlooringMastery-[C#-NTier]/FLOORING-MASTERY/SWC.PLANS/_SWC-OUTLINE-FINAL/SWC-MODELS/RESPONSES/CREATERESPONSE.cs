using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.Models.Responses
{
    public class CREATEResponse : Response

    {
        public Order Order { get; set; }     
        public decimal PriorOrderID { get; set; }
    }
}
