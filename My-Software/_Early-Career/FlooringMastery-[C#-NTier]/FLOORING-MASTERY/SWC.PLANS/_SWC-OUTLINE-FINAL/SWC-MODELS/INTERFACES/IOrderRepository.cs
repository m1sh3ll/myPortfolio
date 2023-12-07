using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.Models.Interfaces
{
    public interface IOrderRepository
    {

        Order DisplayOrder(int OrderNumber, DateTime date);

        List<Order> DisplayAllOrders(DateTime date);

       // CreateResponse Create(Order order, DateTime date);

       // RemoveResponse Remove(Order order, DateTime date);

       // UpdateResponse Update(Order order, DateTime date);



    }
}
