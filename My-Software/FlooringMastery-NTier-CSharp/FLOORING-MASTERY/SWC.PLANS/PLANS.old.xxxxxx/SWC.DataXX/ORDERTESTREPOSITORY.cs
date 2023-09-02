using SWC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWC.Models;

namespace SWC.Data
{
    public class OrderTestRepository : IOrderRepository
    {
        private static Order _order = new Order
        {
            OrderNumber = 1
            CustomerName = "Michelle Nesbitt"
            State = "NY"
            TaxRate = "8.25"
            Type =
            Area =
            CostPerSquareFoot =
            LaborCostPerSquareFoot =
            MaterialCost =
            LaborCost =
            Tax =
            Total =

        };

        public Order DisplayOrder(string OrderNumber)
        {
            return _order;
        }

        public void UpdateOrder(Order order)

        {
            _order = order;
        }
    }
}
