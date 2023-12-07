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
    public class OrderDeleteWorkflow
    {
        Order OrderToDelete;

        OrderManager manager;

        public bool ExecuteMenuDate()
        {
            bool isValid = false;
            Console.Clear();
            Console.WriteLine("Delete Order");
            Console.WriteLine("--------------------------");
            string entry = "";
            while (isValid == false)
            {
                Console.Write("Enter Order Date: (ie. MM/DD/YYYY): ");
                entry = Console.ReadLine();
                Response response = OrderManager.ValidateDate(entry, "Delete");
                isValid = response.Success;
                if (response.Success == false)
                {
                    Console.WriteLine(response.Message + " Please re-enter");
                }
            }
            OrderToDelete.OrderDate = entry;
            return true;
        }


        public bool ExecuteMenuOrderNum()
        {
            bool isValid = false;
            string entry = "";
            while (isValid == false)
            {
                Console.Write("Enter Order Number: (ie. 101): ");
                entry = Console.ReadLine();
                Response response = OrderManager.ValidateOrderNumber(entry);
                isValid = response.Success;
                if (response.Success == false)
                {
                    Console.WriteLine(response.Message + " Please re-enter");
                }
            }
            OrderToDelete.OrderNumber = Int32.Parse(entry);
            return true;
        }

        public void LookupOrder()
        {
            OrderLookupResponse oresponse = manager.LookupOrder(OrderToDelete.OrderNumber, OrderToDelete.OrderDate);

            if (oresponse.Success)
            {
                ConsoleIO.DisplayOrderDetails(oresponse.Order);
            }
            else
            {
                Console.WriteLine("Order does not exist.  ");
                Console.WriteLine(oresponse.Message);
            }
        }


        public void Execute()
        {
            OrderToDelete = new Order();
            manager = OrderManagerFactory.Create();

            if (ExecuteMenuDate() && ExecuteMenuOrderNum())
            {
                LookupOrder();

                Console.Write("Delete this order? (Enter Y or N) or press any key to cancel: ");
                string answer = Console.ReadLine();



                if ((answer == "Y") || (answer == "y"))
                {
                    DeleteOrder();
                }
                else
                {
                    Console.WriteLine("User Canceled.");
                }
                
            }
            else
            {
                Console.WriteLine("Error Deleting Order...");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void DeleteOrder()
        {
            OrderDeleteResponse delresponse = new OrderDeleteResponse();
            delresponse = manager.DeleteOrder(OrderToDelete);

            if (delresponse.Success)
            {
                ConsoleIO.ShowActionSuccess("Order Deleted!!");             
            }
            else
            {
                Console.WriteLine(delresponse.Message);
                ConsoleIO.ShowActionFailure("***Delete Order****");
            }
        }


        //public void Execute()
        //{
        ////public void UpdateOrder()
        ////{
        ////    OrderToAdd = manager.CalculateOrder(OrderToAdd, "Update");

        ////    ConsoleIO.DisplayOrderDetails(OrderToAdd);

        ////    Console.WriteLine("Continue with update? (Enter=Y or press any key to cancel : ");
        ////    string entry = Console.ReadLine();

        ////    if (entry == "Y" || entry == "y")
        ////    {

        ////        OrderUpdateResponse response = manager.UpdateOrder(OrderToAdd);

        ////        if (response.Success)
        ////        {
        ////            ConsoleIO.ShowActionSuccess("Order Updated!!");
        ////        }
        ////        else
        ////        {
        ////            ConsoleIO.ShowActionFailure("***Update Order****");
        ////            Console.WriteLine(response.Message);
        ////        }
        ////    }
        ////}


        // {
        //        

        //            
        //        }
        //        else
        //        {
        //            
        //        }


        //    }
        //    else
        //    {
        //        Console.WriteLine("Order does not exist.  ");
        //        Console.WriteLine(response.Message);
        //    }


        //    Console.WriteLine("Press any key to continue...");
        //    Console.ReadKey();

    }
}


