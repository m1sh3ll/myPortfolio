using SWC.BLL;
using SWC.Models;
using SWC.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.UI.Workflows
{
    public class OrderAddWorkflow
    {
        Order OrderToAdd;
        OrderManager manager;

        public bool ExecuteMenuDate()
        {
            bool isValid = false;
            Console.Clear();
            Console.WriteLine("Add New Order");
            Console.WriteLine("--------------------------");
            string entry = "";
            while (isValid == false)
            {
                Console.Write("Enter Order Date: (ie. MM/DD/YYYY): ");
                entry = Console.ReadLine();
                Response response = OrderManager.ValidateDate(entry, "");
                isValid = response.Success;
                if (response.Success == false)
                {
                    Console.WriteLine(response.Message + " Please re-enter");
                }

            }
            OrderToAdd.OrderDate = entry;
            return true;
        }

        public bool ExecuteMenuCustomerName()
        {

            bool isValid = false;
            string entry = "";
            while (isValid == false)
            {
                Console.Write("Enter Customer Name: ");
                entry = Console.ReadLine();
                Response response = OrderManager.ValidateCustomerName(entry);
                isValid = response.Success;
                if (response.Success == false)
                {
                    Console.WriteLine(response.Message + " Please re-enter");

                }

            }
            OrderToAdd.CustomerName = entry;
            return true;
        }

        public bool ExecuteMenuCustomerState()
        {

            bool isValid = false;
            string entry = "";
            while (isValid == false)
            {
                Console.Write("Enter Customer State: ");
                entry = Console.ReadLine();
                Response response = OrderManager.ValidateState(entry);
                if (response.Success)
                {
                    OrderToAdd.State = entry;
                    OrderToAdd = manager.CalculateTaxRate(OrderToAdd);

                    if (OrderToAdd.TaxRate > 0)
                    {
                        isValid = true;
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid state. Please re-enter");
                }
            }

            return true;
        }

        public bool ExecuteMenuArea()
        {

            bool isValid = false;
            string entry = "";
            while (isValid == false)
            {
                Console.Write("Enter Area in Sq. Ft: ");
                entry = Console.ReadLine();
                Response response = OrderManager.ValidateArea(entry);
                isValid = response.Success;
                if (response.Success == false)
                {
                    Console.WriteLine(response.Message + " Please re-enter");

                }

            }
            OrderToAdd.Area = Int32.Parse(entry);

            return true;
        }

        public bool ExecuteMenuProduct()
        {

            bool isValid = false;
            string entry = "";
            while (isValid == false)
            {
                List<Product> allProducts = new List<Product>();
                Console.WriteLine("Products Available: ");
                ProductLookupResponse pLookupResponse = new ProductLookupResponse();
                pLookupResponse = manager.LookupAllProducts();


                allProducts = pLookupResponse.Products;
                ConsoleIO.DisplayAllProducts(allProducts);
                Console.Write("Enter Product Type: ");
                entry = Console.ReadLine();
                Response response = OrderManager.ValidateProduct(entry);
                if (response.Success)
                {
                    OrderToAdd.ProductType = entry;
                    OrderToAdd = manager.CalculateProduct(OrderToAdd); //sets the cost / labor/sq.ft

                    if (OrderToAdd.ProductType != "")
                    {
                        isValid = true;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product. Please re-enter");
                }
            }
            return true;
        }


        public void AddOrder(Order order)
        {
            order = manager.CalculateOrder(order, "Add");
            ConsoleIO.DisplayOrderDetails(order);
            Console.WriteLine("Continue with order? (Enter=Y or press any key to cancel : ");
            string entry = Console.ReadLine();

            if (entry == "Y" || entry == "y")
            {
                OrderAddResponse response = manager.AddOrder(order);
                if (response.Success)
                {
                    ConsoleIO.ShowActionSuccess("Order Added!!");

                }
                else
                {
                    ConsoleIO.ShowActionFailure("***Add Order****");
                    Console.WriteLine(response.Message);
                }

            }
        }

        public void Execute()
        {
            OrderToAdd = new Order();
            manager = OrderManagerFactory.Create();

            if (ExecuteMenuDate() && ExecuteMenuCustomerName() && ExecuteMenuCustomerState()
                && ExecuteMenuArea() && ExecuteMenuProduct())
            {

                AddOrder(OrderToAdd);
            }
            else
            {
                Console.WriteLine("Error Adding Order...");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

















        }
    }
}
