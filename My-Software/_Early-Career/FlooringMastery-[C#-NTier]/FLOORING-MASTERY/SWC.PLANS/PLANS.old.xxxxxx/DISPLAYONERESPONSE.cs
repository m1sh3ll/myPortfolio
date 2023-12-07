using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.Models.Responses
{
    public class DisplayOneResponse : Response

    {
        public Order Order { get; set; }  //if looking up one order only
       
    }
}
