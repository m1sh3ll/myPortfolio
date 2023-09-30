using NUnit.Framework;
using SWC.BLL;
using SWC.Models;
using SWC.Models.Responses;
using SWC.Models.Interfaces;
using SWC.BLL.AddRules;
using SWC.BLL.EditRules;
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

        [TestCase("101", "OrderXXX", 100, OrderOperationType.Add, 2500, false)]
    
        public void OrderAddRuleTest(string ordernum, string name, string state, decimal taxrate,
                                               string prodtype, decimal amount, bool expectedResult)
        {
            IAdd add = new AddRule();
            Order order = new Order();
            order.OrderNumber = ordernum;
            order.CustName = name;
            order.State = state;
            order.TaxRate = taxrate;
            order.Type = prodtype;
            OrderAddResponse response = add.Add(order, amount);
            Assert.AreEqual(expectedResult, response.Success);
        }

        
        [TestCase("101", "Premium Order", 100, OrderOperationType.Edit, -100, 100, false)]
     
        public void OrderEditRuleTest(
        {
            IEdit Edit = new PremiumOrderEditRule();
            Order order = new Order();
            order.OrderNumber = OrderNumber;
            order.Name = name;
            order.OrderID = OrderID;
            order.Type = OrderOperationType;
            OrderEditResponse response = Edit.Edit(order, amount);
            Assert.AreEqual(expectedResult, response.Success);
            if (response.Success == true)
            {
                Assert.AreEqual(newOrderID, order.OrderID);
            }

        }
        [Test]
        public void CanGetOrderTestData()
        {
            OrderManager manager = OrderManagerFactory.Create();
            OrderSearchResponse response = manager.SearchOrder("101");
            Assert.IsNotNull(response.Order);
            Assert.IsTrue(response.Success);
            Assert.AreEqual("101", response.Order.OrderNumber);
        }


    }
}
