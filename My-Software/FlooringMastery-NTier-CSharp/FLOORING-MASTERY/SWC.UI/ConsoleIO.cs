using SWC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.UI
{
    public class ConsoleIO
    {

       // public static void DisplayOrderDetailsInRows(Order order)

       // {
            //Console.WriteLine();
            //Console.WriteLine("Customer: " + order.CustomerName + "\t\t\tOrder Number: " + order.OrderNumber + "\t\tDate: " + order.OrderDate);
            //Console.WriteLine("--------------------------------------------------------------------------------------------------------------");

            //Console.WriteLine("State", "Tax Rate", "Product", "Area", "Cost/SqFt.", "Labor/SqFt.", "Materials", "Labor", "Tax", "Total");
            //Console.WriteLine("______________________________________________________________________________________________________________");
            //string line = "{1,-8} {2,-12:N} {3,-12} {4,-10:N} {0,-12:c} {1,-12:c} {2,-11:c} {3,-11:c} {4,-11:c} {5,11:c}";

            //Console.WriteLine(line, order.State, order.TaxRate + "%", order.ProductType, order.Area, order.CostPerSquareFoot, order.LaborCostPerSquareFoot, order.MaterialCost, order.LaborCost, order.Tax, order.Total);
            //Console.WriteLine("________________________________________________________________________________________________________________");

            //Console.WriteLine();
           

      //  }
        public static void DisplayOrderDetails(Order order)
        {
            Console.WriteLine("**************************************");
            Console.WriteLine(order.OrderNumber + "  |  " + order.OrderDate);
            Console.WriteLine(order.CustomerName);
            Console.WriteLine(order.State);
            Console.WriteLine("Product: " + order.ProductType);
            Console.WriteLine("Materials: {0,-20:c}", order.MaterialCost);
            Console.WriteLine("Labor Cost: {0,-20:c}", order.LaborCost);
            Console.WriteLine("Tax: {0,-20:c}", order.Tax);            
            Console.WriteLine("Total: {0,-20:c}" , order.Total);
            Console.WriteLine("**************************************");
            Console.WriteLine();
        }
        
        public static void DisplayProductDetails(Product p)
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("Product: " + p.Type);
            Console.WriteLine("Cost/SqFt: {0,-20:c}", p.CostPerSquareFoot);
            Console.WriteLine("Labor Cost/SqFt: {0,-20:c}", p.LaborCostPerSquareFoot) ;
            Console.WriteLine("**************************************");
            Console.WriteLine();
        }
        public static void DisplayAllProducts(List<Product> pList)
        {
            if (pList.Count > 0)
            {
                foreach (var p in pList)
                {
                    DisplayProductDetails(p);
                }
            }
            else
            {
                ShowActionFailure("Display All Products");
                Console.WriteLine("No Products Exist");
            }
        }
        public static void DisplayAllOrdersDetails(List<Order> ordersList)
        {
            if (ordersList.Count > 0)
            {
                foreach (var i in ordersList)
                {
                    DisplayOrderDetails(i);
                }
            }
            else
            {
                ShowActionFailure("Display All Orders");
                Console.WriteLine("No Orders Exist on this date.");
            }
        }

        public static void ShowActionSuccess(string actionName)
        {
            Console.WriteLine("\n{0} executed successfully!", actionName);
        }

        public static void ShowActionFailure(string actionName)
        {
            Console.WriteLine("\n{0} failed to execute properly!", actionName);
        }

    }
}
