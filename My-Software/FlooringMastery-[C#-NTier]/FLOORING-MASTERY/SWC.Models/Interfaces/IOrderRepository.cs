using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWC.Models.Responses;

namespace SWC.Models.Interfaces
{
    public interface IOrderRepository
    { 
        List<Order> DisplayAllOrders(string date);
        Order DisplayOrder(int OrderNumber, string date);       
        OrderAddResponse AddOrder(Order order);
        OrderDeleteResponse DeleteOrder(Order order);
        OrderUpdateResponse UpdateOrder(Order neworder);



    }
}
