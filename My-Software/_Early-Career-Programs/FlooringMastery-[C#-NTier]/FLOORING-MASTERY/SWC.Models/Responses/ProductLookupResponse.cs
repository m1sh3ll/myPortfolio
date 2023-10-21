using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.Models.Responses
{
    public class ProductLookupResponse : Response

    {
        public List<Product> Products { get; set; }
        public Order Order {get; set;}



    }
}
