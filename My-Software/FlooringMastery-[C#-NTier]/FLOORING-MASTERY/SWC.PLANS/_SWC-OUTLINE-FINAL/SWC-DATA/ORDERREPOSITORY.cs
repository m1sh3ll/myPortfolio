using SWC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWC.Models;
using System.IO;

namespace SWC.Data
{
    public class OrderRepository : IOrderRepository
    {
        private string _filePath;
        
        public OrderRepository()
        {
            _filePath = AppDomain.CurrentDomain.BaseDirectory + @"..\..\FILES\Orders_"; //+ 12032021   datestring ; //date string fix
        }

        // list/load, create/add, update/edit, delete
        public List<Order> DisplayAllOrders(DateTime date)
        {
            List<Order> orders = new List<Order>();
            using (StreamReader sr = new StreamReader(_filePath))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Order newOrder = new Order();
                    string[] columns = line.Split(',');
                    newOrder.OrderNumber = columns[0];
                    newOrder.CustomerName = columns[1];
                    //State, string
                  //TaxRate, decimal
                 /////ProductType,
                  //Area,
                  //CostPerSquareFoot,
                  //LaborCostPerSquareFoot,
                  //MaterialCost,
                  //  LaborCost,
                  //Tax,
                  //Total
                    
                    orders.Add(newOrder);
                }
            }

            return orders;
        }


        public Order DisplayOrder(int id) //read one
        {
            var order = DisplayAllOrders();
            var oid = order.Find(a => a.OrderNumber == id);
            return oid;
        }

        public void UpdateOrder(Order oid)
        {
            var orders = DisplayAllOrders();
            var index = orders.FindIndex(s => s.OrderNumber == oid.OrderNumber);
            orders[index] = oid;
            CreateOrderFile(orders);
        }

        private string CreateCsvForOrder(Order order)
        {            

            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}", order.OrderNumber,  order.CustomerName, 
            order.State, Order.TaxRate, Order.ProductType, Order.Area, Order.CostPerSquareFoot, Order.LaborCostPerSquareFoot, Order.MaterialCost,
            Order.LaborCost, Order.Tax, Order.Total);
        }

        private void CreateOrderFile(List<Order> orders)
        {
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }

            using (StreamWriter sw = new StreamWriter(_filePath))
            {
                sw.WriteLine("OrderNumber,CustomerName,State,TaxRate, ProductType,Area,CostPerSquareFoot,LaborCostPerSquareFoot,MaterialCost,LaborCost,Tax,Total");
                foreach (var order in orders)
                {
                    sw.WriteLine(CreateCsvForOrder(order));
                }
            }
        }



        CreateResponse Create(Order order);
        RemoveResponse Remove(Order order);
        UpdateResponse UpdateOrder(Order order);
        Order DisplayOrder(string OrderNumber, DateTime date);

        




    }
}
