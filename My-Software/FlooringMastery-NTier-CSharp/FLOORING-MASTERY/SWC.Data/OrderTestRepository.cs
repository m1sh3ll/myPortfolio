using SWC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWC.Models;
using SWC.Models.Responses;

namespace SWC.Data
{
    public class OrderTestRepository : IOrderRepository
    {
        #region "TEST DATA ONLY" - Lots of instantiation in here -- order #101 - 01/01/2021// order #102 - 02/02/2021 Etc.
        private readonly static decimal area = 100M;
        private readonly static decimal cost = 2.00M;
        private readonly static decimal laborcost = 4.00M;
        private readonly static decimal rate1 = 8.25M;
        private readonly static string state1 = "NY";
    
        //List of hardcoded orders for test repo - loaded at runtime


        private static List<Order> _orders = new List<Order>
        {
            new Order()
                {
                OrderDate = "06/01/2013",
                OrderNumber = 1,
                CustomerName = "Wise",
                State = "OH",
                TaxRate = 6.25M,
                ProductType = "Wood",
                Area = area,
                CostPerSquareFoot = 5.15M,
                LaborCostPerSquareFoot = 4.75M,
                MaterialCost = area * cost,       
                Tax = (area * cost + area * laborcost) * (rate1 / 100M),
                Total = ((area * cost) + (area * laborcost)) * (1 + (rate1 / 100M))},
            new Order()
                {
                OrderDate = "09/01/2021",
                OrderNumber = 1,
                CustomerName = "Michelle Nesbitt",
                State = state1,
                TaxRate = rate1,
                ProductType = "Carpet",
                Area = area,
                CostPerSquareFoot = cost,
                LaborCostPerSquareFoot = laborcost,
                MaterialCost = area * cost,       //Area * CostPerSquareFoot = $200.00
                LaborCost = area * laborcost,         //Area * LaborCostPerSquareFoot = $400.00 //Total Cost = $600.00 * 8.25/100
                Tax = (area * cost + area * laborcost) * (rate1 / 100M),
                Total = ((area * cost) + (area * laborcost)) * (1 + (rate1 / 100M))},
             new Order()
                {
                OrderDate = "09/02/2021",
                OrderNumber = 1,
                CustomerName = "Steve Nesbitt",
                State = state1,
                TaxRate = rate1,
                ProductType = "Carpet",
                Area = area,
                CostPerSquareFoot = cost,
                LaborCostPerSquareFoot = laborcost,
                MaterialCost = area * cost,
                LaborCost = area * laborcost,
                Tax = ((area * cost) + (area * laborcost)) * (rate1 / 100M),
                Total = ((area * cost) + (area * laborcost)) * (1 + (rate1 / 100M)) },
             new Order()
                {
                OrderDate = "09/03/2021",
                OrderNumber = 1,
                CustomerName = "John Nesbitt",
                State = state1,
                TaxRate = rate1,
                ProductType = "Carpet",
                Area = area,
                CostPerSquareFoot = cost,
                LaborCostPerSquareFoot = laborcost,
                MaterialCost = area * cost,       
                LaborCost = area * laborcost,        
                Tax = ((area * cost) + (area * laborcost)) * (rate1 / 100M),
                Total = ((area * cost) + (area * laborcost)) * (1 + (rate1 / 100M)) }

        };
        #endregion       

      
        
        public List<Order> DisplayAllOrders(string date)
        {
            List<Order> orders;
            var allOrders = from o in _orders
                            where o.OrderDate == date
                            select o;
            orders = allOrders.ToList();
            return orders;
        }

        public Order DisplayOrder(int OrderNumber, string date)
        {           
            var allOrders = DisplayAllOrders(date);
            Order order = allOrders.Find(o => o.OrderNumber == OrderNumber);
            return order;
        }
        public OrderAddResponse AddOrder(Order order)
        {          
            OrderAddResponse response = new OrderAddResponse();            
           _orders.Add(order);
            response.Success = true;         
            return response;
        }

        public OrderDeleteResponse DeleteOrder(Order order)
        {
            OrderDeleteResponse response = new OrderDeleteResponse();
            _orders.Remove(order);
            response.Success = true;
            return response;
        }


        public OrderUpdateResponse UpdateOrder(Order order)
        {
            Order order2 = new Order();
            OrderUpdateResponse response = new OrderUpdateResponse();
            _orders.Remove(order);
            _orders.Add(order2);
            response.Success = true;
            return response;
        }


    }
}
