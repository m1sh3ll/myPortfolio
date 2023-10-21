
using SWC.Models;
using SWC.Models.Interfaces;
using SWC.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SWC.Data
{
    public class OrderFileRepository : IOrderRepository
    {
        private string _filePath;
        private string _filedir = AppDomain.CurrentDomain.BaseDirectory;
        private string _basedir = @"..\..\FILES\Orders_";
        private static List<Order> _orders=new List<Order>();

        public string SetFilePath(string date)
        {
            date = date.Replace("/", "");
            _filePath = _filedir + _basedir + date + ".txt";
            return _filePath;
        }

        public Order DisplayOrder(int OrderNumber, string date)
        {
            _filePath = SetFilePath(date);
            _orders = DisplayAllOrders(date);
            Order order = _orders.FirstOrDefault(o => o.OrderNumber == OrderNumber);
            return order;
        }

        public List<Order> DisplayAllOrders(string date)
        {

            _filePath = SetFilePath(date);
            _orders.Clear();
            if(!File.Exists(_filePath))
            {
                _orders = null;
                return _orders;
            }
            if (File.Exists(_filePath))
            {
                using (StreamReader reader = new StreamReader(_filePath))
                {
                    reader.ReadLine();
                    string lineread = reader.ReadLine();
                    while (lineread != null)
                    {
                        try
                        {
                            Order o = new Order();
                            string[] splits = lineread.Split(',');
                            o.OrderDate = date;
                            o.OrderNumber = Convert.ToInt32(splits[0]);
                            o.CustomerName = splits[1];
                            o.State = splits[2];
                            o.TaxRate = Decimal.Parse(splits[3]);
                            o.ProductType = splits[4];
                            o.Area = Decimal.Parse(splits[5]);
                            o.CostPerSquareFoot = Decimal.Parse(splits[6]);
                            o.LaborCostPerSquareFoot = Decimal.Parse(splits[7]);
                            o.MaterialCost = Decimal.Parse(splits[8]);
                            o.LaborCost = Decimal.Parse(splits[9]);
                            o.Tax = Decimal.Parse(splits[10]);
                            o.Total = Decimal.Parse(splits[11]);
                            _orders.Add(o);
                            lineread = reader.ReadLine();
                        }
                        catch
                        {
                            lineread = null;
                        }
                    }                   

                }

          

            }
          

              return _orders;

        }




        public OrderAddResponse AddOrder(Order order)
        {
            OrderAddResponse response = new OrderAddResponse();
            _orders.Add(order);
            _filePath = SetFilePath(order.OrderDate);
            CreateOrderFile(_orders);
            response.Success = true;
            return response;

        }

        public OrderDeleteResponse DeleteOrder(Order order)
        {
            string date = order.OrderDate;
            _orders = DisplayAllOrders(date);
            OrderDeleteResponse response = new OrderDeleteResponse();
            //int index = -1;
            foreach (Order o in _orders)
            {
                if (o.OrderNumber == order.OrderNumber) {
                    order = o;
                    break;
                 }
            }
          if (_orders.Remove(order))
            {
                response.NewOrdersList = _orders;
                _filePath = SetFilePath(date);
                CreateOrderFile(response.NewOrdersList);
                response.Success = true;
            }
            return response;
        }


        public OrderUpdateResponse UpdateOrder(Order order)
        {
            Order neworder = new Order();
            neworder = order;

            OrderUpdateResponse response = new OrderUpdateResponse();
            _filePath = SetFilePath(order.OrderDate);
            string date = order.OrderDate;
            _orders = DisplayAllOrders(date);
            foreach (Order o in _orders)
            {
                if (o.OrderNumber == order.OrderNumber)
                {
                    o.CustomerName = order.CustomerName;
                    o.State = order.State;
                    o.Area = order.Area;
                    o.ProductType = order.ProductType;                   
                    break;
                }
            }
            CreateOrderFile(_orders);
            response.Success = true;
            return response;
        }

        private string CreateLineForOrder(Order order)
        {
            return string.Format("{0},{1},{2},{3:N},{4:N},{5:N},{6:N},{7:N},{8:N},{9:N},{10:N},{11:N}",
                order.OrderNumber.ToString(),
                order.CustomerName, order.State,
                order.TaxRate.ToString(),
                order.ProductType,
                order.Area.ToString(),
                order.CostPerSquareFoot.ToString(),
                order.LaborCostPerSquareFoot.ToString(),
                order.MaterialCost.ToString(),
                order.LaborCost.ToString(),
                order.Tax.ToString(),
                order.Total.ToString());
        }

        private void CreateOrderFile(List<Order> orders)
        {

            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }

            using (StreamWriter writer = new StreamWriter(_filePath))
            {
                writer.WriteLine("OrderNumber,CustomerName,State,TaxRate,ProductType,Area,CostPerSquareFoot,LaborCostPerSquareFoot,MaterialCost,LaborCost,Tax,Total");

                foreach (var order in orders)
                {
                    writer.WriteLine(CreateLineForOrder(order));
                }
            }
        }


    }
}
