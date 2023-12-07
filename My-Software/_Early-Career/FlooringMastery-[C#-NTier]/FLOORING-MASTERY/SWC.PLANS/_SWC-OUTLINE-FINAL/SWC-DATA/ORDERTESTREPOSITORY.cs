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
        //test data
        private readonly static decimal area = 100M;
        private readonly static decimal cpsf = 2.00M;
        private readonly static decimal lcpsf = 4.00M;
        private readonly static decimal rate1 = 8.25M;
        private readonly static string state1 = "NY";
        private readonly static decimal rate2 = 8.5M;
        private readonly static string state2 = "CT";


        private static List<Order> _orderList = new List<Order>
        {
            new Order()
                {
                OrderDate = Convert.ToDateTime("01/10/2021"),
                OrderNumber = 1,
                CustomerName = "Michelle Nesbitt",
                State = state1,
                TaxRate = rate1,
                Type = ProductType.Carpet,
                Area = area,
                CostPerSquareFoot = cpsf,
                LaborCostPerSquareFoot = lcpsf,
                MaterialCost = area * cpsf,       //Area * CostPerSquareFoot = $200.00
                LaborCost = area * lcpsf,         //Area * LaborCostPerSquareFoot = $400.00 //Total Cost = $600.00 * 8.25
                Tax = (area * cpsf + area * lcpsf) * rate1,
                Total = (area * cpsf + area * lcpsf) + (area * cpsf + area * lcpsf) * rate1 },
             new Order()
                {
                OrderDate = Convert.ToDateTime("01/12/2021"),
                OrderNumber = 2,
                CustomerName = "Steve Nesbitt",
                State = state2,
                TaxRate = rate2,
                Type = ProductType.Carpet,
                Area = area,
                CostPerSquareFoot = cpsf,
                LaborCostPerSquareFoot = lcpsf,
                MaterialCost = area * cpsf,       //Area * CostPerSquareFoot = $200.00
                LaborCost = area * lcpsf,         //Area * LaborCostPerSquareFoot = $400.00 //Total Cost = $600.00 * 8.25
                Tax = (area * cpsf + area * lcpsf) * rate2,
                Total = (area * cpsf + area * lcpsf) + (area * cpsf + area * lcpsf) * rate2 }
        };


        public Order DisplayOrder(int OrderNumber, DateTime date)
        {

            var allOrders = DisplayAllOrders(date);
            var order = allOrders.Find(o => o.OrderNumber == OrderNumber);
            return order;
        }

        public List<Order> DisplayAllOrders(DateTime date)
        {
            List<Order> orderlist;
            var allOrdersByDate = from x in _orderList
                                  where x.OrderDate == date
                                  select x;
            orderlist = allOrdersByDate.ToList();
            return orderlist;
        }

        //public CreateResponse Create(Order order, DateTime date) {
        //}

        //public RemoveResponse Remove(Order order, DateTime date) { 
        //}

        //public UpdateResponse Update(Order order, DateTime date) {
        //}
    }
}
