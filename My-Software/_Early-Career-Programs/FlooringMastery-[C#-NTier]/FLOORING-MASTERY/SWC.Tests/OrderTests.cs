using NUnit.Framework;
using SWC.BLL;
using SWC.Models;
using SWC.Models.Responses;
using SWC.Models.Interfaces;
using SWC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.Tests
{
    [TestFixture]
    public class OrderTests
    {
        [TestCase("01/11/2021", 1, "Martha", 100.00, "NY", 1.00, "Wood", 8.25, 2.00, false)]  //enter invalid date (in past)
        [TestCase("01112021-", 1, "Martha", 100.00, "NY", 1.00, "Wood", 8.25, 2.00, false)] //enter invalid date
        [TestCase("09/11/2021", 2, "Michelle,Inc", 100.00, "NJ", 1.25, "Tile", 8.00, 4.00, false)] //invalid name (comma)
        [TestCase("09/11/2021", 3, "Stewart", 100.00, "NR", 1.25, "Tile", 8.00, 4.00, false)] //invalid state
        [TestCase("09/01/2021", 1, "Stewart Jones", 100.00, "PA", 5.0, "Tile", 2.00, 4.00, true)] //valid
        [TestCase("09/01/2021", 2, "Stewart James", 100.00, "PA", 5.0, "Tile", 2.00, 4.00, true)] //valid
        [TestCase("09/01/2021", 3, "Stewart John", 100.00, "PA", 5.0, "Tile", 2.00, 4.00, true)] //valid
        [TestCase("09/02/2021", 1, "Stewart Jones", 100.00, "OH", 8.25, "Laminate", 2.00, 4.00, true)] //valid
        [TestCase("09/02/2021", 2, "Stewart James", 100.00, "OH", 8.25, "Laminate", 2.00, 4.00, true)] //valid
        [TestCase("09/02/2021", 3, "Stewart John", 100.00, "OH", 8.25, "Laminate", 2.00, 4.00, true)] //valid
        [TestCase("09/03/2021", 1, "Stewart Jones", 100.00, "PA", 7.5, "Carpet", 2.00, 4.00, true)] //valid
        [TestCase("09/03/2021", 2, "Stewart James", 100.00, "PA", 7.5, "Carpet", 2.00, 4.00, true)] //valid
        [TestCase("09/03/2021", 3, "Stewart John", 100.00, "PA", 7.5, "Carpet", 2.00, 4.00, true)] //valid
        public void TestOrderAdd(string date, int OrderNum, string Customer, decimal area, string state, decimal rate, string prod, decimal cpsf, decimal lcpsf, bool expectedResult)
        {
            OrderAddResponse response = new OrderAddResponse();
            OrderManager manager = OrderManagerFactory.Create();
            Order o = new Order();
            o.OrderDate = date;
            o.OrderNumber = OrderNum;
            o.CustomerName = Customer;
            o.Area = area;
            o.State = state;
            o.TaxRate = rate;
            o.ProductType = prod;
            o.CostPerSquareFoot = cpsf;
            o.LaborCostPerSquareFoot = lcpsf;
            o.LaborCost = o.Area * o.LaborCostPerSquareFoot;
            o.MaterialCost = o.Area * o.CostPerSquareFoot;
            o.Tax = ((o.MaterialCost + o.LaborCost) * (o.TaxRate/100));
            o.Total = (o.MaterialCost+o.LaborCost + o.Tax);
            response = manager.AddOrder(o);
            Assert.AreEqual(expectedResult, response.Success);
        }

        [TestCase("09/11/2021", 1, true)]
        [TestCase("09/11/2021", 2, true)]
        [TestCase("09/11/2021", 3, true)]
        public void TestOrderDelete(string date, int OrderNum, bool expectedResult)
        {
            OrderDeleteResponse response = new OrderDeleteResponse();
            OrderManager manager = OrderManagerFactory.Create();
            Order o = new Order();
            o.OrderDate = date;
            o.OrderNumber = OrderNum;     
            response = manager.DeleteOrder(o);
            Assert.AreEqual(expectedResult, response.Success);

        }

        [TestCase("09/01/2021", 3, "Updated 3", 200, "PA", "Wood",  true)]
        [TestCase("09/02/2021", 3, "Updated 3", 200, "PA", "Tile",  true)]
        [TestCase("09/03/2021", 3, "Updated 3", 200, "PA",  "Laminate",  true)]
        public void TestOrderUpdate(string date, int ordernumber, string Customer, decimal area, string state, string prod, bool expectedResult)
        {
           
            OrderUpdateResponse response = new OrderUpdateResponse();
            OrderManager manager = OrderManagerFactory.Create();
            Order o = new Order();           
            o.OrderDate = date;
            o.OrderNumber = ordernumber;

            o.CustomerName = Customer;
            o.Area = area;
            o.State = state;
            o.ProductType = prod; 
            response = manager.UpdateOrder(o);
            Assert.AreEqual(expectedResult, response.Success);

        }

        [Test]
        public void CanLoadOrderTestData()
        {
            OrderManager manager = OrderManagerFactory.Create();
            OrderLookupResponse response = manager.LookupOrder(1, "06/01/2013");
            Assert.IsNotNull(response.Order);
            Assert.IsTrue(response.Success);
            Assert.AreEqual(1, response.Order.OrderNumber);
        }


    }
}
