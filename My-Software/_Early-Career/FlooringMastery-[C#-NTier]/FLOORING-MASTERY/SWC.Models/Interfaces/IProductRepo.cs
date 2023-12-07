using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWC.Models.Responses;


namespace SWC.Models.Interfaces
{
    public interface IProductRepo
    {
        Product DisplayProduct(string s);


       List<Product> DisplayAllProducts();
    }
}
