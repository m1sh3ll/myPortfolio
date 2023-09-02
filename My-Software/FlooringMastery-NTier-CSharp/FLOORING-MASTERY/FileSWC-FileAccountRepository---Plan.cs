

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
    public class OrderFileRepository : IOrderRepository
    {
        private string _filePath;
        private string _filelocation = AppDomain.CurrentDomain.BaseDirectory;
        private string _basedir = @"..\..\FILES\Orders_"
              
        public FileOrderRepository(string date)
        {
            date = date.Replace("/", "");
            _filePath = _filelocation + _basedir + date + ".txt";            
        }



        public List<Order> DisplayAllOrders(string date)
        {
            List<Order> orders = new List<Order>();   
            
            using (StreamReader reader = new StreamReader(_filePath))
            {
                reader.ReadLine();
                string lineread;
                while ((lineread = reader.ReadLine()) != null)
                {
                    Order o = new Order();
                    string[] splits = lineread.Split(',');
                    o.OrderNumber = splits[0];
                    o.OrderCustomerName = splits[1];
                    o.State = splits[2];
                    o.TaxRate = decimal.Parse(splits[3]);
                    o.ProductType = splits[4];
                    o.Area = decimal.Parse(splits[5]);
                    o.CostPerSquareFoot = decimal.Parse([splits[6]]);
                    o.LaborCostPerSquareFoot = decimal.Parse([splits[7]]);
                    o.MaterialCost = decimal.Parse([splits[8]]);
                    o.LaborCost = decimal.Parse([splits[9]]);
                    o.Tax = decimal.Parse([splits[10]]);
                    o.Total = decimal.Parse([splits[11]]);                                        
                    orders.Add(o);
                }
            }         

            return orders;
        }

       
        public Order DisplayOrder(int OrderNumber, string date)
        {
            var allOrders = DisplayAllOrders(date);
            var order = allOrders.Find(o => o.OrderNumber == OrderNumber);
            return order;
        }

        public void SaveOrder(Order acct)
        {
            var orders = ListOrders();
            var index = orders.FindIndex(s => s.OrderNumber == acct.OrderNumber);
            orders[index] = acct;

            CreateOrderFile(orders);
        }

        private string CreateCsvForOrder(Order order)
        {
            string sType = "F";
            switch (order.Type)
            {
                case OrderType.Premium:
                    sType = "P";
                    break;
                case OrderType.Basic:
                    sType = "B";
                    break;
            }

            return string.Format("{0},{1},{2},{3}", order.OrderNumber, order.Name, order.Balance.ToString(), sType);
        }

        private void CreateOrderFile(List<Order> orders)
        {
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }

            using (StreamWriter sw = new StreamWriter(_filePath))
            {
                sw.WriteLine("OrderNumber,Name,Balance,Type");

                foreach (var order in orders)
                {
                    sw.WriteLine(CreateCsvForOrder(order));
                }
            }
        }







    }
}
