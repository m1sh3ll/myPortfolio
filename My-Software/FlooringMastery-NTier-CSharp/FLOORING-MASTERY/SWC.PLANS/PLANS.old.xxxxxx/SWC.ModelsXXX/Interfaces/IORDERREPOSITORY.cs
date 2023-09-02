using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.Models.Interfaces
{
    public interface IOrderRepository
    {
        CreateResponse Create(Order order);

        RemoveResponse Remove(Order order);

        UpdateResponse UpdateOrder(Order order);

        Order DisplayOrder(string OrderNumber, DateTime date); 




    }
}
