using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.Models.Responses
{
    public class DisplayResponse : Response
    {
        public Order order { get; set; }
    }
}
