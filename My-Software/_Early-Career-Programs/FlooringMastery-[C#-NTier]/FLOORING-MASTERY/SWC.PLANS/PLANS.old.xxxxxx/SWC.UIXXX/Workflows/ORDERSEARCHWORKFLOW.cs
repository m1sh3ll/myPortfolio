using SWC.BLL;
using SWC.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.UI.Workflows
{
    public class OrderSearchWorkflow
    {
        public void Execute()
        {
            OrderManager manager = OrderManagerFactory.Create();

            Console.Clear();
            Console.WriteLine("Search an order");
            Console.WriteLine("--------------------------");
            Console.Write("Enter an order number: ");
            string orderNumber = Console.ReadLine();

            OrderSearchResponse response = manager.SearchOrder(orderNumber);

            if(response.Success)
            {
                ConsoleIO.DisplayOrderDetails(response.Order);
            }
            else
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(response.Message);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
